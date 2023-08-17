using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    public class Student
    {
        public static Dictionary<int, Student> Studenten { get; } = new Dictionary<int, Student>();

        public string Name { get; set; }
        public int Matrikelnr { get; set; }
        public string Studiengang {get ; set; }
        public string Jahrgang { get; set; }
        public string Gruppe { get; set; } 
        
        public Student(string name, int matrikelnr, string studiengang, string jahrgang, string gruppe)
        {
            Name = name; 
            Matrikelnr = matrikelnr; 
            Studiengang = studiengang; 
            Jahrgang = jahrgang; 
            Gruppe = gruppe;  

            Studenten.Add(matrikelnr,this);
        }
    }

    
}
