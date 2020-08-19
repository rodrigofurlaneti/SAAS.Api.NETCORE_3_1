using System.Collections.Generic;
namespace SAAS.Infra
{
    public class RetornoComSelect<T>
    {
        public List<T> ListaObj { get; set; }
        public Dictionary<string, dynamic> PS { get; set; }
        public bool Ok { get; set; }
        public string MensagemProc { get; set; }
        public RetornoComSelect()
        {
            ListaObj = new List<T>();
            PS = new Dictionary<string, dynamic>();
            Ok = true;
            MensagemProc = "";
        }
    }
}
