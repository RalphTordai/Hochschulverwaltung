using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    public class Lerngruppe
    {

        public static Dictionary<string, Lerngruppe> Lerngruppen { get; } = new Dictionary<string, Lerngruppe>();

        public string Name { get; }
        public List<Student> Studenten { get; } = new List<Student>();


        public Lerngruppe(string Name, List<Student> Studenten)
        {
            this.Name = Name;
            this.Studenten = Studenten;

            Lerngruppen.Add(this.Name, this);
        }
    }
}
