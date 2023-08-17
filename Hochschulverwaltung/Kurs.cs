using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    public class Kurs
    {
        public string KursID { get;}
        public string Name { get; set; }
        public Dozent Dozent { get; set; }
        public Lerngruppe Lerngruppe { get; set; }
    }
    
}

