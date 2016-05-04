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
    public partial class EditClassByManager : Form
    {
        public EditClassByManager()
        {
            InitializeComponent();
        }

        private void EditClassByManager_Load(object sender, EventArgs e){
            dataGridView1.DataSource = User.Instance.manager.GetAllClasses();
        }

        private void Add_Click(object sender, EventArgs e){
            if (User.Instance.manager.AddClass(textBox3.Text, textBox4.Text, comboBox1.Text, maskedTextBox1.Text)) MessageBox.Show("קורס חדש נוסף בהצלחה"  + maskedTextBox1.Text);
            dataGridView1.DataSource = Class.getAll();
        }

        private void button1_Click(object sender, EventArgs e){
            if (User.Instance.manager.RemoveClass(textBox2.Text)) MessageBox.Show("קורס נמחק בהצלחה");
            dataGridView1.DataSource = User.Instance.manager.GetAllClasses();
            textBox2.Text = "";
        }




    }
}
