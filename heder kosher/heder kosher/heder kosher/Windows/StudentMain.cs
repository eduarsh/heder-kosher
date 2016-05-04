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
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }

        private void StudentMain_Load(object sender, EventArgs e){

        }

        private void ShowProgramTraining_Click(object sender, EventArgs e){
            TrainingProgramWindow temp = new TrainingProgramWindow();
            temp.ShowDialog();
        }

        private void RegisterToClass_Click(object sender, EventArgs e){
            RegisterAndRemoveStudentFromClassStudentWindow temp = new RegisterAndRemoveStudentFromClassStudentWindow();
            temp.ShowDialog();
        }
    }
}
