using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCESACNA.Engine.Core;
using OCESACNA.Engine.Collections;

namespace OCESACNA.View.Forms
{
    public partial class StudentForm : Form, Collections.IDataForm
    {
        public Signal Acepted = new Signal();
        public Signal Canceled = new Signal();
        public DataFormType FormType { get; set; }

        public enum DataFormType
        {
            None = 0,
            Create = 1,
            Update = 2
        }

        public StudentForm()
        {
            InitializeComponent();
        }

        public void SetData(Dictionary<string, dynamic> data)
        {

        }

        public object[] GetData()
        {
            return new object[0];
        }

        public void ClearData()
        {

        }

        private void AceptBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Acepted.Emit(e);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Canceled.Emit(e);
        }
    }
}
