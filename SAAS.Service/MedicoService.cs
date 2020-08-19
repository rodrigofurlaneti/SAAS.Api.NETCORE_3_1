using SAAS.Model;
using SAAS.Infra;
using System.Data;
namespace SAAS.Service{
    public class MedicoService{
        public static RetornoComSelect<Medico> SelecionarTodosMedicos(){
            var proc = new ProcCaller("SP_SEL_MEDICO");
            proc.AdicionarParametroSaida("PS_RETURN", DbType.Int16);
            proc.AdicionarParametroSaida("PS_MESSAGE", DbType.String);
            var ret = proc.ExecutarComSelect<Medico>();
            return ret;
        }
    }
}
