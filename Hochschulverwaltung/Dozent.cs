using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
   
    public class Dozent
    {
        public static Dictionary<string, Dozent> Dozenten { get; } = new Dictionary<string, Dozent>();
        public string Name { get; set; }
        public bool Festangestellt { get; set; }
        public Dozent(string Name, bool Festangestellt)
        {
            this.Name = Name;
            this.Festangestellt = Festangestellt;

            Dozenten.Add(this.Name, this);
        }
    }
}
