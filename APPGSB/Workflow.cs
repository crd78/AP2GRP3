using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class Workflow
    {
        public DateTime date { get; set; }
        public etapes etape { get; set; }
        public decisions decision { get; set; }
        public Workflow(DateTime laDate, etapes lEtape,decisions laDecision)
        {
            this.date = laDate;
            this.etape = lEtape;
            decision = laDecision;
        }
    }
}
