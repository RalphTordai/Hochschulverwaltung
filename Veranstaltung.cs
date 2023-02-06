using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal class Veranstaltung
    {
        enum VeranstaltungsTyp
        {
            Infoveranstaltung,
            Klausur,
            Vorlesung,
            Sonstiges
            
        }
        private string uuid;
        private string name;
        private List<Student> students;
        private VeranstaltungsTyp veranstaltungsTyp;
    }
}
