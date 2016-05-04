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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {

        }

        private void AddRemoveEmp_Click(object sender, EventArgs e)
        {
            AddRemoveEmployee temp = new AddRemoveEmployee();
            temp.ShowDialog();
        }

        private void AddRemoveCourse_Click(object sender, EventArgs e)
        {
            EditClassByManager temp = new EditClassByManager();
            temp.ShowDialog();
        }
    }
}
