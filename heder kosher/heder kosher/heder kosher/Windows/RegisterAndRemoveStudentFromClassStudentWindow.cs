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
    public partial class RegisterAndRemoveStudentFromClassStudentWindow : Form
    {
        public RegisterAndRemoveStudentFromClassStudentWindow(){
            InitializeComponent();
        }

        private void RegisterAndRemoveStudentFromClassStudentWindow_Load(object sender, EventArgs e){
            dataGridView1.DataSource = User.Instance.student.ShowAllClass();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            if (User.Instance.student.registerToClass(User.Instance.student.ID, textBox1.Text))
                MessageBox.Show("ההרשמה נקלטה בהצלחה");
            else MessageBox.Show("שגיאה בהרשמה");
        }

        private void button2_Click(object sender, EventArgs e){
            if (User.Instance.student.removeStudentFromClass(User.Instance.student.ID)) MessageBox.Show("מחיקה התבצעה בהצלחה");
            else MessageBox.Show("אינך רשום לחוג. אם בעיה זו ממשיכה פנה למוקד השירות");
        }
    }
}
