namespace StudentManagementSystem
{
    partial class studentUpdate
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
            studentUpdateFormUsernameLabel = new Label();
            studentUpdateFormStudentNumberLabel = new Label();
            studentUpdateFormAgeLabel = new Label();
            studentUpdateFormClassLabel = new Label();
            studentUpdateFormsSaveButton = new Button();
            studentUpdateFormsCancelButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // studentUpdateFormUsernameLabel
            // 
            studentUpdateFormUsernameLabel.AutoSize = true;
            studentUpdateFormUsernameLabel.Location = new Point(87, 68);
            studentUpdateFormUsernameLabel.Name = "studentUpdateFormUsernameLabel";
            studentUpdateFormUsernameLabel.Size = new Size(86, 31);
            studentUpdateFormUsernameLabel.TabIndex = 0;
            studentUpdateFormUsernameLabel.Text = "姓名：";
            studentUpdateFormUsernameLabel.Click += this.studentUpdateFormUsernameLabel_Click;
            // 
            // studentUpdateFormStudentNumberLabel
            // 
            studentUpdateFormStudentNumberLabel.AutoSize = true;
            studentUpdateFormStudentNumberLabel.Location = new Point(87, 158);
            studentUpdateFormStudentNumberLabel.Name = "studentUpdateFormStudentNumberLabel";
            studentUpdateFormStudentNumberLabel.Size = new Size(86, 31);
            studentUpdateFormStudentNumberLabel.TabIndex = 1;
            studentUpdateFormStudentNumberLabel.Text = "学号：";
            // 
            // studentUpdateFormAgeLabel
            // 
            studentUpdateFormAgeLabel.AutoSize = true;
            studentUpdateFormAgeLabel.Location = new Point(87, 242);
            studentUpdateFormAgeLabel.Name = "studentUpdateFormAgeLabel";
            studentUpdateFormAgeLabel.Size = new Size(62, 31);
            studentUpdateFormAgeLabel.TabIndex = 2;
            studentUpdateFormAgeLabel.Text = "年龄";
            // 
            // studentUpdateFormClassLabel
            // 
            studentUpdateFormClassLabel.AutoSize = true;
            studentUpdateFormClassLabel.Location = new Point(87, 315);
            studentUpdateFormClassLabel.Name = "studentUpdateFormClassLabel";
            studentUpdateFormClassLabel.Size = new Size(62, 31);
            studentUpdateFormClassLabel.TabIndex = 3;
            studentUpdateFormClassLabel.Text = "班级";
            // 
            // studentUpdateFormsSaveButton
            // 
            studentUpdateFormsSaveButton.Location = new Point(124, 408);
            studentUpdateFormsSaveButton.Name = "studentUpdateFormsSaveButton";
            studentUpdateFormsSaveButton.Size = new Size(150, 46);
            studentUpdateFormsSaveButton.TabIndex = 4;
            studentUpdateFormsSaveButton.Text = "保存";
            studentUpdateFormsSaveButton.UseVisualStyleBackColor = true;
            // 
            // studentUpdateFormsCancelButton
            // 
            studentUpdateFormsCancelButton.Location = new Point(366, 408);
            studentUpdateFormsCancelButton.Name = "studentUpdateFormsCancelButton";
            studentUpdateFormsCancelButton.Size = new Size(150, 46);
            studentUpdateFormsCancelButton.TabIndex = 5;
            studentUpdateFormsCancelButton.Text = "取消";
            studentUpdateFormsCancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 38);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 38);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 38);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 308);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 38);
            textBox4.TabIndex = 9;
            // 
            // studentUpdate
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 524);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(studentUpdateFormsCancelButton);
            Controls.Add(studentUpdateFormsSaveButton);
            Controls.Add(studentUpdateFormClassLabel);
            Controls.Add(studentUpdateFormAgeLabel);
            Controls.Add(studentUpdateFormStudentNumberLabel);
            Controls.Add(studentUpdateFormUsernameLabel);
            Name = "studentUpdate";
            Text = "学生信息";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentUpdateFormUsernameLabel;
        private Label studentUpdateFormStudentNumberLabel;
        private Label studentUpdateFormAgeLabel;
        private Label studentUpdateFormClassLabel;
        private Button studentUpdateFormsSaveButton;
        private Button studentUpdateFormsCancelButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}