﻿using System;
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
    public partial class studentCourseSelectionForm : Form
    {
        public studentCourseSelectionForm()
        {
            InitializeComponent();
            studentCourseSelectionFormToolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            studentCourseSelectionFormTimer.Start();
        }

        private void studentCourseSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            studentCourseSelectionFormToolStripStatusLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
