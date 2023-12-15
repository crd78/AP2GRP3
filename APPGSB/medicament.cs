using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class medicament
    {
        public string depotLegal { get; set; }
        public string nomCommercial { get; set; }
        public string codeFamille { get; set; }
        public string composition { get; set; }
        public string effets { get; set; }
        public string contreIndication { get; set; }
        public int prix { get; set; }
        public string amm { get; set; }
        public string etp_num { get; set; }
     
        public medicament(string depotLegal, string nomCommercial, string codeFamille, string composition, string effets, string contreIndication, string amm, string etp_num)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.codeFamille = codeFamille;
            this.composition = composition;
            this.effets = effets;
            this.contreIndication = contreIndication;
            this.prix = 0;
            this.amm = amm;
            this.etp_num = etp_num;
        }
        public string getCodeFamille()
        {
            return this.codeFamille;
        }
        public string getDepotLegal()
        {
            return this.depotLegal;
        }
        public string getNomCommercial()
        {
            return this.nomCommercial;
        }
    }
}
