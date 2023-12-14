using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class Workflow
    {
        private DateTime date { get; set; }
        private etapes etape { get; set; }
        private decisions decision { get; set; }
        public Workflow(DateTime laDate, etapes lEtape,decisions laDecision)
        {
            this.date = laDate;
            this.etape = lEtape;
            decision = laDecision;
        }
    }
}
