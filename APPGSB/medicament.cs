﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class medicament
    {
        private string depotLegal { get; set; }
        private string nomCommercial { get; set; }
        private string codeFamille { get; set; }
        private string composition { get; set; }
        private string effets { get; set; }
        private string contreIndication { get; set; }
        private int prix { get; set; }
        public medicament(string depotLegal, string nomCommercial, string codeFamille, string composition, string effets, string contreIndication)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.codeFamille = codeFamille;
            this.composition = composition;
            this.effets = effets;
            this.contreIndication = contreIndication;
            this.prix = 0;
        }
    }
}