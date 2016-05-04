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
    public partial class AddStudent : Form{

        public AddStudent()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Details1.Text != "" && Details2.Text != "" && Details3.Text != "" && Details4.Text != "" && details6.Text != "" && Details7.Text != ""){

                if (User.Instance.currentUser.AddNewStudent(Details1.Text, Details2.Text, Details3.Text, Details4.Text, Details5.SelectedItem.ToString(), details6.Text, Details7.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString())){
                    MessageBox.Show("הוספת עובד נקלטה בהצלחה");
                    //clear box
                    Details1.Text = "";
                    Details2.Text = "";
                    Details3.Text = "";
                    Details4.Text = "";
                    details6.Text = "";
                    Details7.Text = "";
                }
                else MessageBox.Show("שגיאה בהוספת עובד");
            }

            else
                MessageBox.Show("אחד או יותר מהשדות ריקים");


        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Details9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Details7_TextChanged(object sender, EventArgs e)
        {

        }

        private void details6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Details1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRemoveStudentBySecratry_Load(object sender, EventArgs e)
        {

        }


    }
}
