using SAAS.Model;
using SAAS.Infra;
using System.Data;
namespace SAAS.Service{
    public class EspecialidadeService{
        public static RetornoComSelect<Especialidade> SelecionarTodasEspecialidades(){
            var proc = new ProcCaller("SP_SEL_ESPECIALIDADE");
            proc.AdicionarParametroSaida("PS_RETURN", DbType.Int16);
            proc.AdicionarParametroSaida("PS_MESSAGE", DbType.String);
            var ret = proc.ExecutarComSelect<Especialidade>();
            return ret;
        }
    }
}
