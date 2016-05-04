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
    public partial class RegisterAndRemoveStudentFromClassSecretaryWindow : Form
    {
        private ReceptionEmployee secretary = new ReceptionEmployee();
        
        public RegisterAndRemoveStudentFromClassSecretaryWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e){
            if (secretary.registerToClass(textBox1.Text, textBox2.Text)){
                MessageBox.Show("סטודנט התווסף לקורס בהצלחה");
                dataGridView1.DataSource = secretary.ShowAllStudentFromClass();
            }
            else MessageBox.Show("שגיאה בהוספת סטודנט לקורס");
        }

        private void Remove_Click(object sender, EventArgs e){
            if (secretary.removeStudentFromClass(textBox3.Text)){
                MessageBox.Show("סטודנט הוסר מקורס בהצלחה");
                dataGridView1.DataSource = secretary.ShowAllStudentFromClass();
            }
            else MessageBox.Show("שגיאה בהסרת סטודנט מקורס");
        }

        private void showAllClass_Click(object sender, EventArgs e){
            if (secretary.ShowAllClass().Rows.Count > 0)
                dataGridView1.DataSource = User.Instance.secratry.ShowAllClass();
            else MessageBox.Show("לא נמצאו חוגים");

        }

        private void button1_Click(object sender, EventArgs e){
            if (User.Instance.secratry.ShowAllStudentFromClass().Rows.Count > 0)
                dataGridView1.DataSource = secretary.ShowAllStudentFromClass();
            else MessageBox.Show("לא נמצאו חוגים");
        }

        private void RegisterAndRemoveStudentFromClassSecretaryWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
