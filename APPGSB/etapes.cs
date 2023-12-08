using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class etapes
    {
        public int etp_num {  get; set; }
        public string etp_libelle { get; set; }
        public string etp_norme { get; set; }
        public string etp_date_norme { get; set; }
        public int estNormee { get; set; }
        public etapes(int etp_num, string etp_libelle, string etp_norme, string etp_date_norme, int estNormee)
        {
            this.etp_num = etp_num;
            this.etp_libelle = etp_libelle;
            this.etp_norme = etp_norme;
            this.etp_date_norme = etp_date_norme;
            this.estNormee = estNormee;
        }
    }
}
