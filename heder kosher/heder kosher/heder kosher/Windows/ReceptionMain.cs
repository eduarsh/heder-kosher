using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heder_Kosher
{
    public partial class ReceptionMain : Form
    {
        public ReceptionMain()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e){
            RegisterAndRemoveStudentFromClassSecretaryWindow secr = new RegisterAndRemoveStudentFromClassSecretaryWindow();
            secr.ShowDialog();
        }

        private void addRemoveStudent_Click(object sender, EventArgs e){
            AddStudent temp = new AddStudent();
            temp.ShowDialog();
        }

        private void RemoveStudent_Click(object sender, EventArgs e){
            RemoveStudent temp = new RemoveStudent();
            temp.ShowDialog();
        }

        private void ReceptionMain_Load(object sender, EventArgs e)
        {

        }
    }
}
