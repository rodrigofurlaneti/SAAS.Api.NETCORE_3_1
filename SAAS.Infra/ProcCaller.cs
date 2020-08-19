using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Newtonsoft.Json;
namespace SAAS.Infra
{
    public class ProcCaller
    {
        public string NomeProc { get; set; }
        public List<ParametroProc> ParametrosEntrada { get; set; }
        public List<ParametroProc> ParametrosSaida { get; set; }
        public string ConnectionString { get; set; }
        public int Timeout { get; set; }
        public ProcCaller(string nomeProc)
        {
            this.NomeProc = nomeProc;
            this.ParametrosEntrada = new List<ParametroProc>();
            this.ParametrosSaida = new List<ParametroProc>();
            this.ConnectionString = new DbConnection().GetConnectionString();
            this.Timeout = 300;
        }
        public ParametroProc AdicionarParametroEntrada(string nome, DbType tipo, dynamic valor)
        {
            var param = new ParametroProc
            {
                Nome = nome,
                Valor = valor,
                Tipo = tipo
            };
            this.ParametrosEntrada.Add(param);
            return param;
        }

        public ParametroProc AdicionarParametroSaida(string nome, DbType tipo)
        {
            var param = new ParametroProc
            {
                Nome = nome,
                Valor = null,
                Tipo = tipo
            };
            this.ParametrosSaida.Add(param);
            return param;
        }
        public RetornoSemSelect ExecutarSemSelect()
        {
            return (RetornoSemSelect)this.Executar<Object>(possuiMapeamentoSelect: false);
        }
        public RetornoComSelect<T> ExecutarComSelect<T>()
        {
            return (RetornoComSelect<T>)this.Executar<T>(possuiMapeamentoSelect: true);
        }
        private dynamic Executar<T>(bool possuiMapeamentoSelect)
        {
            var retorno = new RetornoComSelect<T>();
            using (var sqlConnection = new SqlConnection(this.ConnectionString))
            {
                var dynamicParameters = new DynamicParameters();
                var PE = new Dictionary<string, dynamic>();
                foreach (ParametroProc pEntrada in this.ParametrosEntrada)
                {
                    try
                    {
                        switch(pEntrada.Tipo)
                        {
                            case DbType.String:
                                pEntrada.Valor = Convert.ToString(pEntrada.Valor);
                                break;
                            case DbType.Int16:
                            case DbType.Int32:
                            case DbType.Int64:
                                pEntrada.Tipo = DbType.Int32;
                                pEntrada.Valor = Convert.ToInt32(pEntrada.Valor);
                                break;
                            case DbType.Decimal:
                                pEntrada.Valor = Convert.ToDecimal(pEntrada.Valor);
                                break;
                            case DbType.Date:
                                if (pEntrada.Valor == null || pEntrada.Valor.Equals(""))
                                {
                                    pEntrada.Valor = null;
                                }else if(pEntrada.Valor.GetType() == typeof(string))
                                {
                                    pEntrada.Valor = Convert.ToDateTime(pEntrada.Valor);
                                }else
                                {
                                    pEntrada.Valor = (DateTime)pEntrada.Valor;
                                }
                                break;
                        }
                    }
                    catch
                    {
                        pEntrada.Valor = null;
                    }
                    dynamicParameters.Add(pEntrada.Nome, pEntrada.Valor, pEntrada.Tipo, ParameterDirection.Input, -1);
                    PE.Add(pEntrada.Nome, pEntrada.Valor);
                }
                foreach(ParametroProc pSaida in this.ParametrosSaida)
                {
                    dynamicParameters.Add(pSaida.Nome, null, pSaida.Tipo, ParameterDirection.Output, -1);
                }

                string jsonTeste = JsonConvert.SerializeObject(new { NomeProc = this.NomeProc, PE = ParametrosEntrada });
                retorno.ListaObj = sqlConnection.Query<T>(this.NomeProc, dynamicParameters, commandTimeout: this.Timeout, commandType: CommandType.StoredProcedure).ToList();
                retorno.PS = new Dictionary<string, dynamic>();
                foreach (ParametroProc pSaida in this.ParametrosSaida)
                {
                    retorno.PS[pSaida.Nome.Replace("PS_", "")] = dynamicParameters.Get<dynamic>(pSaida.Nome);
                }
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
            if (Convert.ToInt32(retorno.PS["RETURN"]) != 0)
            {
                retorno.Ok = false;
            }
            else
            {
                retorno.Ok = true;
            }
            if (possuiMapeamentoSelect)
            {
                return retorno;
            }
            else
            {
                return new RetornoSemSelect()
                {
                    PS = retorno.PS,
                    Ok = retorno.Ok,
                    MensagemProc = retorno.MensagemProc
                };
            }
        }


    }
}
