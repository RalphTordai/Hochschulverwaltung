using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal class Studiengruppe
    {
        private string uuid;
        private string name; // z. B. dWi2021A2

        public Studiengruppe(string name)
        {
            this.name = name;
        }
    }
}
