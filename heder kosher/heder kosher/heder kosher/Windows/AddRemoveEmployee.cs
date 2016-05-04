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
    public partial class AddRemoveEmployee : Form
    {
        public AddRemoveEmployee()
        {
            InitializeComponent();
        }

        private void AddRemoveEmployee_Load(object sender, EventArgs e){
            
        }

        private void Remove_Click(object sender, EventArgs e){
            try{
                ((Manager)User.Instance.currentUser).RemoveEmployee(Remove.Text);
            }
            catch{
                MessageBox.Show("בעיה בהוספת עובד בדוק האם תעודת זהות תקינה ונסה שנית");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {

                User.Instance.manager.AddEmployee(Details1.Text, Details2.Text, Details3.Text, Details4.Text, Details5.SelectedItem.ToString(), details6.Text, Details7.Text, Details9.SelectedItem.ToString(), int.Parse(Details8.Text));
                MessageBox.Show("העובד נקלט בהצלחה");
            }

            catch
            {
                MessageBox.Show("אחד או יותר מהפריטים לא תקינים");
            }
            finally
            {
                Details1.Text = "";
                Details2.Text = "";
                Details3.Text = "";
                Details4.Text = "";
                Details5.Text = "";
                details6.Text = "";
                Details7.Text = "";
                Details8.Text = "";
                Details9.Text = "";
                Details8.Text = "";
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
