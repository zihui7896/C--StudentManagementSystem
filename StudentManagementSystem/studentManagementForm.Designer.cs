namespace StudentManagementSystem
{
    partial class studentManagementForm
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
            信息管理ToolStripMenuItem = new ToolStripMenuItem();
            添加ToolStripMenuItem = new ToolStripMenuItem();
            删除ToolStripMenuItem = new ToolStripMenuItem();
            修改ToolStripMenuItem = new ToolStripMenuItem();
            搜索ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusTimeLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            systemTimer = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            usernameColumn = new DataGridViewTextBoxColumn();
            studentNumberColumn = new DataGridViewTextBoxColumn();
            ageColumn1 = new DataGridViewTextBoxColumn();
            classColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统ToolStripMenuItem, 信息管理ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1134, 39);
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
            // 信息管理ToolStripMenuItem
            // 
            信息管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 添加ToolStripMenuItem, 删除ToolStripMenuItem, 修改ToolStripMenuItem, 搜索ToolStripMenuItem });
            信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            信息管理ToolStripMenuItem.Size = new Size(130, 35);
            信息管理ToolStripMenuItem.Text = "信息管理";
            // 
            // 添加ToolStripMenuItem
            // 
            添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            添加ToolStripMenuItem.Size = new Size(195, 44);
            添加ToolStripMenuItem.Text = "添加";
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(195, 44);
            删除ToolStripMenuItem.Text = "删除";
            // 
            // 修改ToolStripMenuItem
            // 
            修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            修改ToolStripMenuItem.Size = new Size(195, 44);
            修改ToolStripMenuItem.Text = "修改";
            // 
            // 搜索ToolStripMenuItem
            // 
            搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            搜索ToolStripMenuItem.Size = new Size(195, 44);
            搜索ToolStripMenuItem.Text = "查找";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusTimeLabel });
            statusStrip1.Location = new Point(0, 566);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1134, 41);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(110, 31);
            toolStripStatusLabel1.Text = "欢迎使用";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(944, 31);
            toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusTimeLabel
            // 
            toolStripStatusTimeLabel.Name = "toolStripStatusTimeLabel";
            toolStripStatusTimeLabel.Size = new Size(65, 31);
            toolStripStatusTimeLabel.Text = "time";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 39);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1134, 42);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.add_circle;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.ashbin;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(46, 36);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.修改;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(46, 36);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // systemTimer
            // 
            systemTimer.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { usernameColumn, studentNumberColumn, ageColumn1, classColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1134, 485);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // usernameColumn
            // 
            usernameColumn.HeaderText = "姓名";
            usernameColumn.MinimumWidth = 10;
            usernameColumn.Name = "usernameColumn";
            // 
            // studentNumberColumn
            // 
            studentNumberColumn.HeaderText = "学号";
            studentNumberColumn.MinimumWidth = 10;
            studentNumberColumn.Name = "studentNumberColumn";
            // 
            // ageColumn1
            // 
            ageColumn1.HeaderText = "年龄";
            ageColumn1.MinimumWidth = 10;
            ageColumn1.Name = "ageColumn1";
            // 
            // classColumn
            // 
            classColumn.HeaderText = "班级";
            classColumn.MinimumWidth = 10;
            classColumn.Name = "classColumn";
            // 
            // studentManagementForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 607);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "studentManagementForm";
            Text = "学生管理";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem 信息管理ToolStripMenuItem;
        private ToolStripMenuItem 添加ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 搜索ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer systemTimer;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusTimeLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn usernameColumn;
        private DataGridViewTextBoxColumn studentNumberColumn;
        private DataGridViewTextBoxColumn ageColumn1;
        private DataGridViewTextBoxColumn classColumn;
    }
}