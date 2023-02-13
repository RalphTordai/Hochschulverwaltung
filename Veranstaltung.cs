using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal abstract class Veranstaltung
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
        private List<Student> studenten;
        private VeranstaltungsTyp veranstaltungsTyp;
        private string beschreibung;

        private List<Termin> termine;

    }
}
