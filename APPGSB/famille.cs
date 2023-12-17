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
        private List<medicament> lesMedicaments;
        public famille(string Lid, string LeLibelle)
        {
            this.id = Lid;
            this.libelle = LeLibelle;
            this.lesMedicaments = new List<medicament>();
        }
        public string getId() { return this.id; }
        public string getLibelle() { return this.libelle; }
        public List<medicament> getLesMedicaments() { return this.lesMedicaments; }
    }
}
