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

        

        UserControl openWindow = null;

        public Hochschulverwaltung()
        {
            for (int i = 0; i < 100; i++)
            {
                RandomStudentGenerator.GenerateRandomStudent();
            }

            InitializeComponent();

            openWindow = new ResourcenAnlegen();

            layoutMainWindow.Controls.Add(openWindow);
            openWindow.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openWindow = new ResourcenAnlegen();
            layoutMainWindow.Controls.RemoveAt(layoutMainWindow.Controls.Count - 1);
            layoutMainWindow.Controls.Add(openWindow);
            openWindow.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openWindow = new Terminplan();
            layoutMainWindow.Controls.RemoveAt(layoutMainWindow.Controls.Count - 1);
            layoutMainWindow.Controls.Add(openWindow);
            openWindow.Dock = DockStyle.Fill;
        }

    }
}
