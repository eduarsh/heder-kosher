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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginB_Click(object sender, EventArgs e){

            if (User.Instance.LoadUser(UserID.Text, UserPass.Text))
                ChangeScreen();
            else
                MessageBox.Show("שגיאה בפרטי ההתחברות");
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeScreen()
        {
            switch (User.Instance.currentUser.Rank)
            {
                case "Student":
                    StudentMain student = new StudentMain();
                    this.Visible = false;
                    //check valid subscription and madicen 
                    if (!Student.checkValidConection())
                    {
                        MessageBox.Show("מנוי או אישור רפואי לא בתוקף, לבירור נוסף נא התקשר לשרות לקוחות");
                        break;
                    }
                    student.ShowDialog();
                    break;

                case "Trainer":
                    TrainerMain Trainer = new TrainerMain();
                    this.Visible = false;
                    Trainer.ShowDialog();
                    break;

                case "Instructor":
                    InstructorMain Instructor = new InstructorMain();
                    this.Visible = false;
                    Instructor.ShowDialog();
                    break;

                case "Secretary":
                    ReceptionMain Reception = new ReceptionMain();
                    this.Visible = false;
                    Reception.ShowDialog();
                    break;

                case "Manager":
                    ManagerMain Manager = new ManagerMain();
                    this.Visible = false;
                    Manager.ShowDialog();
                    break;

            }

            this.Visible = true;
        }
    }
}
