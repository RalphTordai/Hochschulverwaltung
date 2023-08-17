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
    public partial class Hochschulverwaltung : Form
    {

        List<Dozent> Dozenten { get; } = new List<Dozent>();
        
        List<Kurs> Kurse { get; } = new List<Kurs>();

        List<Stundenplan> Stundenplaene { get; } = new List<Stundenplan>();

        UserControl openWindow = null;

        public Hochschulverwaltung()
        {

            InitializeComponent();

            openWindow = new ResourcenAnlegen( Dozenten, Kurse, Stundenplaene);

            layoutMainWindow.Controls.Add(openWindow);
            openWindow.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openWindow = new ResourcenAnlegen( Dozenten, Kurse, Stundenplaene);
            layoutMainWindow.Controls.RemoveAt(layoutMainWindow.Controls.Count - 1);
            layoutMainWindow.Controls.Add(openWindow);
            openWindow.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
