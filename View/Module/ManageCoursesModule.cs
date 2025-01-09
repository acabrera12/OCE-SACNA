using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;

namespace OCESACNA.View.Module
{
    public partial class ManageCoursesModule : Form
    {
        int selectedID = -1;
        bool isEditing = false;
        public ManageCoursesModule()
        {
            InitializeComponent();
        }

        private void ManageCoursesModule_Load(object sender, EventArgs e)
        {
            ConnectManager.GetAllCourses(ReciveData);
            ConnectManager.DataModified.Connect(UpdateCoursesData);
        }

        private void UpdateCoursesData(object sender, EventArgs e)
        {
            ConnectManager.GetAllCourses(ReciveData);
        }

        private void GetCoursesData(Course[] list)
        {
            string[] vars = { "1thYear", "2thYear", "3thYear", "4thYear", "5thYear" };
            TreeNodeCollection nodes = Tree.Nodes;

            int index = 0;
            foreach (string year in vars)
            {
                foreach (Course course in list.Where(e => vars[e.Year] == year))
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

            for (index = 0; index < vars.Length; index++)
            {
                foreach (TreeNode node in nodes[index].Nodes)
                {
                    foreach (Course c in list.Where(e => e.Year == index && e.Mention == node.Text))
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

                Invoke(new Action(() => GetCoursesData(list)));
            }
        }
        private void CreateMBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditMBtn_Click(object sender, EventArgs e)
        {

        }

        private void EraseMBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateSBtn_Click(object sender, EventArgs e)
        {

        }

        private void EraseSBtn_Click(object sender, EventArgs e)
        {

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

        private void Clear()
        {
            MentionNameBox.Text = string.Empty;
        }
    }
}
