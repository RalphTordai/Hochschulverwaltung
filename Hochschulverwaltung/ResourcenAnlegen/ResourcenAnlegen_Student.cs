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
    public partial class ResourcenAnlegen_Student : UserControl
    {
        public ResourcenAnlegen_Student()
        {
            InitializeComponent();
        }

        private void Bttn_Erstellen_Click(object sender, EventArgs e)
        {
            try { new Student(inputName.Text, int.Parse(inputMatrikelnr.Text), inputStudiengang.Text, inputJahrgang.Text, inputGruppe.Text); }
            catch { } 
        }
    }
}
