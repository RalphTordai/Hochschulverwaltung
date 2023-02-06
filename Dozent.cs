using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal class Dozent : Person
    {

        public Dozent(string nachName, string vorName, string eMail) : base(nachName, vorName, eMail)
        {
        }
    }
}
