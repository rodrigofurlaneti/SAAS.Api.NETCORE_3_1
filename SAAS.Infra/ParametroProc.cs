using System.Data;
namespace SAAS.Infra { 
    public class ParametroProc
    {
        public string Nome { get; set; }
        public dynamic Valor { get; set; }
        public DbType Tipo { get; set; }
        public ParametroProc(){}
    }
}
