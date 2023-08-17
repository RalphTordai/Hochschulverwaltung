using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal class Termin
    {
        public static Dictionary<string, Termin> Termine = new Dictionary<string, Termin>();
      
        public string TerminID { get; set; }
        public DateTime DateTime { get; set; }
        public Kurs Kurs { get; set; }
        public int Dauer { get; set; }

        public Termin(DateTime DateTime, Kurs Kurs, int Dauer) { 
        
            this.Kurs = Kurs;

            this.DateTime = DateTime;
            TerminID = "Test" + DateTime.Date;
            this.Dauer = Dauer;
            Termine.Add(TerminID, this);
        }

    }
}
