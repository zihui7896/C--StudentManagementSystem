namespace StudentManagementSystem
{
    partial class studentCourseSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            系统ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            选择该课ToolStripMenuItem = new ToolStripMenuItem();
            我的课程ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            studentCourseSelectionFormToolStripStatusLabel = new ToolStripStatusLabel();
            studentCourseSelectionFormTimer = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统ToolStripMenuItem, 选择该课ToolStripMenuItem, 我的课程ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(865, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            系统ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 退出ToolStripMenuItem });
            系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            系统ToolStripMenuItem.Size = new Size(82, 35);
            系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(195, 44);
            退出ToolStripMenuItem.Text = "退出";
            // 
            // 选择该课ToolStripMenuItem
            // 
            选择该课ToolStripMenuItem.Name = "选择该课ToolStripMenuItem";
            选择该课ToolStripMenuItem.Size = new Size(130, 35);
            选择该课ToolStripMenuItem.Text = "选择该课";
            // 
            // 我的课程ToolStripMenuItem
            // 
            我的课程ToolStripMenuItem.Name = "我的课程ToolStripMenuItem";
            我的课程ToolStripMenuItem.Size = new Size(130, 35);
            我的课程ToolStripMenuItem.Text = "我的课程";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, studentCourseSelectionFormToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 409);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(865, 41);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(206, 31);
            toolStripStatusLabel1.Text = "欢迎使用选课系统";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(579, 31);
            toolStripStatusLabel2.Spring = true;
            // 
            // studentCourseSelectionFormToolStripStatusLabel
            // 
            studentCourseSelectionFormToolStripStatusLabel.Name = "studentCourseSelectionFormToolStripStatusLabel";
            studentCourseSelectionFormToolStripStatusLabel.Size = new Size(65, 31);
            studentCourseSelectionFormToolStripStatusLabel.Text = "time";
            studentCourseSelectionFormToolStripStatusLabel.Click += toolStripStatusLabel3_Click;
            // 
            // studentCourseSelectionFormTimer
            // 
            studentCourseSelectionFormTimer.Interval = 1000;
            studentCourseSelectionFormTimer.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(865, 370);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "课程编号";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 195;
            // 
            // Column2
            // 
            Column2.HeaderText = "课程名称";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 196;
            // 
            // Column3
            // 
            Column3.HeaderText = "课程学分";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 195;
            // 
            // Column4
            // 
            Column4.HeaderText = "授课老师";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 195;
            // 
            // studentCourseSelectionForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "studentCourseSelectionForm";
            Text = "studentCourseSelectionForm";
            Load += studentCourseSelectionForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel studentCourseSelectionFormToolStripStatusLabel;
        private System.Windows.Forms.Timer studentCourseSelectionFormTimer;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 选择该课ToolStripMenuItem;
        private ToolStripMenuItem 我的课程ToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}