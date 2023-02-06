using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal abstract class Person
    {
        private string uuid;
        private string nachName;
        private string vorName;
        private string eMail;
        
        public Person(string nachName, string vorName, string eMail)
        {
            uuid = Guid.NewGuid().ToString(); //todo: Selbst implementieren oder wenn nicht,  zumindest verstehen.
            this.nachName = nachName;
            this.vorName = vorName;
            this.eMail = eMail;
        }
    }



}
