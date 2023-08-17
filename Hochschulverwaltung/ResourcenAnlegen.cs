using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hochschulverwaltung
{
    public partial class ResourcenAnlegen : UserControl
    {

        List<Dozent> Dozenten { get; } = null;

        List<Kurs> Kurse { get; } = null;

        List<Stundenplan> Stundenplaene { get; } = null;

        UserControl auswahl = null;

        public ResourcenAnlegen(List<Dozent> dozenten, List<Kurs> kurse, List<Stundenplan> stundenplaene)
        {
            InitializeComponent();

            Dozenten = dozenten;
            Kurse = kurse;
            Stundenplaene = stundenplaene;
            auswahl = new ResourcenAnlegen_Student();
            layoutResourcenAnlegen.Controls.Add(auswahl);
        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropDown.Text)
            {
                case "Dozent":
                    auswahl = new ResourcenAnlegen_Dozent();

                    break;

                case "Lerngruppe":
                    auswahl = new ResourcenAnlegen_Lerngruppe();
                    break; 

                case "Student":
                    auswahl = new ResourcenAnlegen_Student();

                    break;

                default: break;
            }

            if (auswahl != null)
            {
                if (layoutResourcenAnlegen.Controls.Count > 0)
                {
                    layoutResourcenAnlegen.Controls.RemoveAt(layoutResourcenAnlegen.Controls.Count - 1);
                }
                layoutResourcenAnlegen.Controls.Add(auswahl);
                
            }
        }
    }
}
