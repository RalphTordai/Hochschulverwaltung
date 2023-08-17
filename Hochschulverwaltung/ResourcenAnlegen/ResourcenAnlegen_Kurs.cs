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
    public partial class ResourcenAnlegen_Kurs : UserControl
    {
        public ResourcenAnlegen_Kurs()
        {
            InitializeComponent();
            FillInputLerngruppenSelection();
            FillInputDozentSelection();
        }

        private void FillInputLerngruppenSelection()
        {
            foreach (var lerngruppe in Lerngruppe.Lerngruppen.Values)
            {
                inputLerngruppe.Items.Add(lerngruppe.Name);
            }
        }

        private void FillInputDozentSelection()
        {
            foreach (var Dozent in Dozent.Dozenten.Values)
            {
                inputDozent.Items.Add(Dozent.Name);
            }
        }

        private void Bttn_Erstellen_Click(object sender, EventArgs e)
        {
            new Kurs(inputName.Text, Dozent.Dozenten[inputDozent.Text], Lerngruppe.Lerngruppen[inputLerngruppe.Text]);
            foreach(Kurs kurs in Kurs.Kurse.Values){
                Console.WriteLine(kurs.KursID + kurs.Name + kurs.Dozent.Name + kurs.Lerngruppe.Name );
            }
        }
    }
}
