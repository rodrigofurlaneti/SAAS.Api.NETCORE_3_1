using System.Collections.Generic;
namespace SAAS.Infra{
    public class RetornoSemSelect{
        public Dictionary<string, dynamic> PS { get; set; }
        public bool Ok { get; set; }
        public string MensagemProc { get; set; }
        public RetornoSemSelect(){
            PS = new Dictionary<string, dynamic>();
            Ok = true;
            MensagemProc = "";
        }
    }
}
