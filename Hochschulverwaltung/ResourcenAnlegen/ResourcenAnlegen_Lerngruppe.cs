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
    public partial class ResourcenAnlegen_Lerngruppe : UserControl
    {
        List<Student> checkedStudents;
        public ResourcenAnlegen_Lerngruppe()
        {
            this.Dock = DockStyle.Fill;

            for (int i = 0; i < 100; i++)
            {
                RandomStudentGenerator.GenerateRandomStudent();
            }
            
            InitializeComponent();
            FillInputNameSelection();


        }

        private void FillInputNameSelection()
        {
            foreach (var lerngruppe in Lerngruppe.Lerngruppen.Values)
            {
                inputName.Items.Add(lerngruppe.Name);
            }
        }
       

        private void DisplaySelectedLerngruppe(string Name)
        {
            Lerngruppe selectedLerngruppe = Lerngruppe.Lerngruppen[Name];
            foreach( Student student in selectedLerngruppe.Studenten)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { student.Matrikelnr.ToString(), student.Name, student.Studiengang });
                listViewSelected.Items.Add(listViewItem);
            }
        }

       

        private void treeViewStudenten_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (e.Action != TreeViewAction.Unknown)
            {
                SetChildrenChecked(e.Node);
            }
        }

        private void SetChildrenChecked(TreeNode treeNode)
        {
            foreach (TreeNode item in treeNode.Nodes)
            {
                if (item.Checked != treeNode.Checked)
                {
                    item.Checked = treeNode.Checked;
                }

                if (item.Nodes.Count > 0)
                {
                    SetChildrenChecked(item);
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            checkedStudents = treeViewStudenten.GetCheckedStudents();

            

            // Assuming you have a ListView named listViewStudents
            listViewSelected.Items.Clear();

            foreach (var student in checkedStudents)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { student.Matrikelnr.ToString(), student.Name,  student.Studiengang  });
                listViewSelected.Items.Add(listViewItem);
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            new Lerngruppe(inputName.Text, checkedStudents);
            inputName.Text = "";
            listViewSelected.Items.Clear();
            FillInputNameSelection();

        }

        private void inputName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedLerngruppe(inputName.Text);
        }
    }
}
