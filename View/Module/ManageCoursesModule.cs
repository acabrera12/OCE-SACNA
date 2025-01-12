using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;
using OCESACNA.Engine.DBCollections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OCESACNA.View.Module
{
    public partial class ManageCoursesModule : Form
    {
        Course[] CourseList;

        int selectedID = -1;
        bool isEditing = false;
        bool isCreating = false;
        readonly string[] YearsNames = { "1thYear", "2thYear", "3thYear", "4thYear", "5thYear" };


        public ManageCoursesModule()
        {
            InitializeComponent();
        }

        private void ManageCoursesModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllCourses(ReciveData);
            ConnectManager.DataModified.Connect(UpdateCoursesData);
            YearBox.SelectedIndex = 0;
            SectionBox.SelectedIndex = 0;
        }

        private void UpdateCoursesData(object sender, EventArgs e)
        {
            if (isCreating)
            {
                return;
            }

            ConnectManager.GetAllCourses(ReciveData);
        }

        private void GetCoursesData(Course[] list)
        {
            CourseList = list;

            TreeNodeCollection nodes = Tree.Nodes;

            int index = 0;
            foreach (string year in YearsNames)
            {
                foreach (Course course in CourseList.Where(e => YearsNames[e.Year] == year))
                {
                    if (nodes[index].Nodes.Count == 0)
                    {
                        nodes[index].Nodes.Add(course.Mention);
                    }
                    else
                    {
                        bool dup = false;

                        foreach (TreeNode node in nodes[index].Nodes)
                        {
                            if (node.Text == course.Mention)
                            {
                                dup = true;
                                break;
                            }
                        }

                        if (!dup)
                        {
                            nodes[index].Nodes.Add(course.Mention);
                        }
                    }
                }

                index++;
            }

            for (index = 0; index < YearsNames.Length; index++)
            {
                foreach (TreeNode node in nodes[index].Nodes)
                {
                    foreach (Course c in CourseList.Where(e => e.Year == index && e.Mention == node.Text))
                    {
                        node.Nodes.Add(c.Section);
                    }
                }
            }
        }

        private void ReciveData(object sender, RequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Course[] list = new Course[e.Response.Count];

                int index = 0;
                foreach (Dictionary<string, dynamic> obj in e.Response)
                {
                    Course c = ConversionManager.DictionaryToCourse(obj);
                    list.SetValue(c, index);
                    index++;
                }

                Invoke(new Action(() => ClearNodes()));
                Invoke(new Action(() => GetCoursesData(list)));
            }
        }

        private void ClearNodes()
        {
            TreeNodeCollection nodes = Tree.Nodes;

            foreach (TreeNode node in nodes)
            {
                node.Nodes.Clear();
            }

            DataGrid.Rows.Clear();
        }

        private void CreateMBtn_Click(object sender, EventArgs e)
        {
            isCreating = true;

            if (MentionNameBox.Text.Replace(" ", "") == string.Empty)
            {
                MentionNameBox.Text = MentionNameBox.Text.Replace(" ", "");
                MessageBox.Show("Rellene los campos");
                return;
            }

            if (YearBox.SelectedIndex == 0) // todos los años
            {
                for (int i = 0; i < YearBox.Items.Count - 1; i++)
                {
                    ConnectManager.AddCourse(new Engine.DBCollections.DBCourse(-1, i, MentionNameBox.Text, 'A'));
                }
            }
            else
            {
                ConnectManager.AddCourse(new DBCourse(-1, YearBox.SelectedIndex - 1, MentionNameBox.Text, 'A'));
            }

            Clear();
            isCreating = false;
        }

        private void EditMBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            if (YearBox.SelectedIndex == 0)
            {
                MessageBox.Show("Esta acción no se puede realizar");
                return;
            }

            if (MentionNameBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            DBCourse course = new DBCourse()
            {
                CourseID = selectedID,
                Year = YearBox.SelectedIndex - 1,
                Mention = MentionNameBox.Text.ToString(),
                Section = Char.Parse(SectionBox.SelectedItem.ToString())
            };

            ConnectManager.UpdateCourse(course);
            selectedID = -1;
            Clear();
        }

        private void EraseMBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            Course cc = CourseList.Where(c => c.CourseID == selectedID).First();

            if (MessageBox.Show($"¿Quieres eliminar la mención '{cc.Mention}'? \nEsta acción no se puede revertir", "Confirmar Acción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string q = $"DELETE FROM `courses` WHERE `Year` = '{cc.Year}' AND `Mention` = '{cc.Mention}'";
                ConnectManager.RunCustom(q);
                Clear();

                selectedID = -1;
            }
        }

        private void CreateSBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }
            Course cc = CourseList.Where(c => c.CourseID == selectedID).First();

            if (CourseList.Where(c => c.Year == cc.Year && c.Mention == cc.Mention && c.Section == SectionBox.SelectedItem.ToString()).Count() != 0)
            {
                MessageBox.Show($"Ya existe '{YearBox.Items[cc.Year + 1]} de {cc.Mention} {cc.Section}'");
                return;
            }

            string s = SectionBox.Items[SectionBox.SelectedIndex].ToString();

            if (MessageBox.Show($"¿Quieres añadir la sección '{s}' a la \nmención '{cc.Mention}' de {YearBox.Items[cc.Year + 1]}?", "Confirmar Acción", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            DBCourse dbcc = new DBCourse()
            {
                Year = cc.Year,
                Mention = cc.Mention,
                Section = char.Parse(s)
            };

            ConnectManager.AddCourse(dbcc);
            selectedID = -1;
            Clear();
        }

        private void EraseSBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Seleccione un elemento");
                return;
            }

            Course cc = CourseList.Where(c => c.CourseID == selectedID).First();

            if (MessageBox.Show($"¿Quieres eliminar la sección '{cc.Section}' de\nla mención '{cc.Mention}' de {YearBox.Items[cc.Year + 1]}?", "Confirmar Acción", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            ConnectManager.DeleteCourse(selectedID);
            selectedID = -1;
            Clear();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                CreateMBtn.Enabled = false;

                if (MentionNameBox.Text == "")
                {
                    CreateMBtn.Enabled = true;
                    isEditing = false;
                }

                return;
            }

            if (MentionNameBox.Text != "")
            {
                EraseMBtn.Enabled = false;
                EditMBtn.Enabled = false;
            }
            else
            {
                EraseMBtn.Enabled = true;
                EditMBtn.Enabled = true;
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].Name != "Selection")
            {
                return;
            }

            int index = e.RowIndex;

            if (index >= 0)
            {
                isEditing = true;
                selectedID = int.Parse(DataGrid.Rows[index].Cells["ID"].Value.ToString());

                MentionNameBox.Text = DataGrid.Rows[index].Cells["Mention"].Value.ToString();

                foreach (string item in YearBox.Items)
                {
                    if (item == DataGrid.Rows[index].Cells["Year"].Value.ToString())
                    {
                        YearBox.SelectedIndex = YearBox.Items.IndexOf(item);
                        break;
                    }
                }

                foreach (string item in SectionBox.Items)
                {
                    if (item == DataGrid.Rows[index].Cells["Section"].Value.ToString())
                    {
                        SectionBox.SelectedIndex = SectionBox.Items.IndexOf(item);
                        break;
                    }
                }
            }
        }

        private void Tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!YearsNames.Contains(e.Node.Name))
            {
                return;
            }

            if (DataGrid.Rows.Count != 0)
            {
                DataGrid.Rows.Clear();
            }

            foreach (Course course in CourseList.Where(c => YearsNames[c.Year] == e.Node.Name))
            {
                DataGrid.Rows.Add(new object[] { "", course.CourseID, e.Node.Text, course.Mention, course.Section });
            }
        }

        private void Clear()
        {
            MentionNameBox.Text = string.Empty;
        }
    }
}
