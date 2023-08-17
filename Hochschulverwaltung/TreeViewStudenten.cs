using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hochschulverwaltung
{
    internal class TreeViewStudenten : TreeView
    {
        public TreeViewStudenten():base()
        {
            FillTreeViewStudenten();
            this.CheckBoxes = true;
        }
        public List<Student> GetCheckedStudents()
        {
            var checkedStudents = new List<Student>();
            GetCheckedStudentsRecursive(this.Nodes, checkedStudents);
            return checkedStudents;
        }

        private void GetCheckedStudentsRecursive(TreeNodeCollection nodes, List<Student> checkedStudents)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked && node.Tag is Student student)
                {
                    checkedStudents.Add(student);
                }

                GetCheckedStudentsRecursive(node.Nodes, checkedStudents);
            }
        }
        public void FillTreeViewStudenten()
        {
            //this.Nodes.Clear();

            // Group students by Studiengang
            var studiengangGroups = Student.Studenten.Values.GroupBy(s => s.Studiengang);

            foreach (var studiengangGroup in studiengangGroups)
            {
                var studiengangNode = new TreeNode(studiengangGroup.Key);

                // Group students within the Studiengang by Jahrgang
                var jahrgangGroups = studiengangGroup.GroupBy(s => s.Jahrgang);

                foreach (var jahrgangGroup in jahrgangGroups)
                {
                    var jahrgangNode = new TreeNode(jahrgangGroup.Key);

                    // Group students within the Jahrgang by Gruppe
                    var gruppeGroups = jahrgangGroup.GroupBy(s => s.Gruppe);

                    foreach (var gruppeGroup in gruppeGroups)
                    {
                        if (string.IsNullOrEmpty(gruppeGroup.Key))
                        {
                            // Add individual student nodes directly under the Jahrgang node
                            foreach (var student in gruppeGroup)
                            {
                                var studentNode = new TreeNode(student.Matrikelnr + "; " + student.Name);
                                studentNode.Tag = student;
                                jahrgangNode.Nodes.Add(studentNode);
                            }
                        }
                        else
                        {
                            var gruppeNode = new TreeNode(gruppeGroup.Key);

                            // Add individual student nodes within the Gruppe
                            foreach (var student in gruppeGroup)
                            {
                                var studentNode = new TreeNode(student.Matrikelnr + "; " + student.Name);
                                studentNode.Tag = student;
                                gruppeNode.Nodes.Add(studentNode);
                            }

                            jahrgangNode.Nodes.Add(gruppeNode);
                        }
                    }

                    studiengangNode.Nodes.Add(jahrgangNode);
                }

                this.Nodes.Add(studiengangNode);
            }
        }
    }
}
