using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class decisions
    {
        private int id { get; set; }
        private string libelle { get; set; }
        public decisions(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
