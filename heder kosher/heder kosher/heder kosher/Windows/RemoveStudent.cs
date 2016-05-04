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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("שדה ריק");

            else if (User.Instance.currentUser.RemoveStudent(textBox1.Text))
            {
                MessageBox.Show("סטודנט נמחק בהצלחה");
                dataGridView1.DataSource = Access.Select("*", "Users WHERE rank = 'Student'");
            }
            else MessageBox.Show("שגיאה בהסרת סטודנט בדוק אם תעודת זהות זו קיימת");
        }

        private void RemoveStudentBySecretary_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Access.Select("*", "Users WHERE rank = 'Student'");
        }
    }
}
