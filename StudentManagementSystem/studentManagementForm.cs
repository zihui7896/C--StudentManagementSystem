using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class studentManagementForm : Form
    {
        public studentManagementForm()
        {
            InitializeComponent();

            toolStripStatusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            systemTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
