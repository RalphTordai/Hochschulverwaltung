using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    public class Kurs
    {
        public static Dictionary<string, Kurs> Kurse { get; } = new Dictionary<string, Kurs>();
        public string KursID { get;}
        public string Name { get; set; }
        public Dozent Dozent { get; set; }
        public Lerngruppe Lerngruppe { get; set; }

        public Kurs(string Name, Dozent Dozent, Lerngruppe Lerngruppe) {
            this.Name = Name;
            this.Dozent = Dozent;
            this.Lerngruppe = Lerngruppe;
            KursID = Lerngruppe.Name+ "-" + Name;

            Kurse.Add(KursID, this);
        }
    }
    
    
}

