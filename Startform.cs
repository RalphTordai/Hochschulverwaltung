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
    public partial class Startform : Form
    {
        RessourcenErstellen ressourcenErstellen;
        public Startform()
        {
            InitializeComponent();
        }

        private void Btn_RessourcenErstellen_Click(object sender, EventArgs e)
        {
            ressourcenErstellen = new RessourcenErstellen();
            ressourcenErstellen.Show();
            this.Hide();
        }

        private void Btn_Einstellungen_Click(object sender, EventArgs e)
        {

        }

        private void Tbl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
