﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    class decisions
    {
        public int id { get; set; }
        public string libelle { get; set; }
        public decisions(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
