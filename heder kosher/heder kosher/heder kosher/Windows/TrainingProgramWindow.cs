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
    public partial class TrainingProgramWindow : Form
    {
        public TrainingProgramWindow()
        {
            InitializeComponent();
        }

        private void TrainingProgramWindow_Load(object sender, EventArgs e){
            ShowTraining();
        }

        private void Next_Click(object sender, EventArgs e){
            User.Instance.student.NextTrainingProgram();
            ShowTraining();
        }

        private void ShowTraining(){
            if (User.Instance.student.ShowTrainingProgram() != null){
                textBox1.Text = "Student ID: " + User.Instance.student.ShowTrainingProgram()[0].ToString() + Environment.NewLine;
                textBox1.Text += "Trainer ID: " + User.Instance.student.ShowTrainingProgram()[1].ToString() + Environment.NewLine;
                textBox1.Text += "Device Name: " + User.Instance.student.ShowTrainingProgram()[2].ToString() + Environment.NewLine;
                textBox1.Text += Environment.NewLine + Environment.NewLine + "Training Program: " + User.Instance.student.ShowTrainingProgram()[3].ToString() + Environment.NewLine;
            }

            else{
                textBox1.Text = "Do You Even Lift Bro !?";
                Next.Enabled = false;
                Previous.Enabled = false;
            }
        }

        private void Previous_Click(object sender, EventArgs e){
            User.Instance.student.PreTrainingProgram();
            ShowTraining();
        }


        private void TrainingProgramWindow_FormClosed(object sender, FormClosedEventArgs e){
            User.Instance.student.ResetTcount();
        } 
    }
}
