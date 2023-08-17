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
    public partial class ResourcenAnlegen_Dozent : UserControl
    {
        public ResourcenAnlegen_Dozent()
        {
            InitializeComponent();
        }

        private void Bttn_Erstellen_Click(object sender, EventArgs e)
        {
            if(inputFestangestellt.Text == "Ja") 
            { new Dozent(inputName.Text, true); }
            else { new Dozent(inputName.Text, false); }
            inputFestangestellt.Text = null;
            inputName.Text = null;
        }
    }
}
