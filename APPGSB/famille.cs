using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class famille
    {
        private string id;
        private string libelle;
        public famille(string Lid, string LeLibelle)
        {
            this.id = Lid;
            this.libelle = LeLibelle;
        }
        public string getId() { return this.id; }
        public string getLibelle() { return this.libelle; }
    }
}
