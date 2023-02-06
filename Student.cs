using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    internal class Student : Person
    {
        private int matrikelNr;


        public Student(string nachName, string vorName, string eMail) : base(nachName, vorName, eMail)
        {
        }
    } 
}
