using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschulverwaltung
{
    public static class RandomStudentGenerator
    {
        private static Random random = new Random();
        private static string[] surnames = { "Müller", "Schneider", "Fischer", "Weber", "Meyer", "Wagner", "Becker" };
        private static string[] givenNames = { "Lukas", "Leon", "Nico", "Tim", "Julian", "Timo", "Paul" };

        public static Student GenerateRandomStudent()
        {





            string[] studiengang = { "WI", "EAM", "BA", "VWA", "HM" };
            string[] jahrgang = {  "2021", "2022"};
            string[] gruppe = { "Gruppe A", "Gruppe B", string.Empty };
            string name = surnames[random.Next(surnames.Length)]+ ", " + givenNames[random.Next(givenNames.Length)] ;
            int matrikelnr = GenerateRandomMatrikelNr();
            string selectedStudiengang = studiengang[random.Next(studiengang.Length)];
            string selectedJahrgang = jahrgang[random.Next(jahrgang.Length)];
            string selectedGruppe = gruppe[random.Next(gruppe.Length)];

            return new Student(name, matrikelnr, selectedStudiengang, selectedJahrgang, selectedGruppe);
        }

        private static int GenerateRandomMatrikelNr()
        {
            const int minMatrikelNr = 100000;
            const int maxMatrikelNr = 999999;
            return random.Next(minMatrikelNr, maxMatrikelNr + 1);
        }
    }

}
