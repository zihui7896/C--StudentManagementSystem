namespace StudentManagementSystem
{
    partial class teachersInformationForm1
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
            studentInformationFormCancelButton = new Button();
            studentInformationFormSaveButton = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            studentInformationFormClassLabel = new Label();
            studentInformationFormAgeLabel = new Label();
            studentInformationFormStudentNumberLabel = new Label();
            studentInformationFormUsernameLabel = new Label();
            SuspendLayout();
            // 
            // studentInformationFormCancelButton
            // 
            studentInformationFormCancelButton.Location = new Point(405, 382);
            studentInformationFormCancelButton.Name = "studentInformationFormCancelButton";
            studentInformationFormCancelButton.Size = new Size(150, 46);
            studentInformationFormCancelButton.TabIndex = 19;
            studentInformationFormCancelButton.Text = "cancel";
            studentInformationFormCancelButton.UseVisualStyleBackColor = true;
            studentInformationFormCancelButton.Click += studentInformationFormCancelButton_Click;
            // 
            // studentInformationFormSaveButton
            // 
            studentInformationFormSaveButton.Location = new Point(121, 382);
            studentInformationFormSaveButton.Name = "studentInformationFormSaveButton";
            studentInformationFormSaveButton.Size = new Size(150, 46);
            studentInformationFormSaveButton.TabIndex = 18;
            studentInformationFormSaveButton.Text = "save";
            studentInformationFormSaveButton.UseVisualStyleBackColor = true;
            studentInformationFormSaveButton.Click += studentInformationFormSaveButton_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(324, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 38);
            textBox4.TabIndex = 17;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(324, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 38);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 38);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 38);
            textBox1.TabIndex = 14;
            // 
            // studentInformationFormClassLabel
            // 
            studentInformationFormClassLabel.AutoSize = true;
            studentInformationFormClassLabel.Location = new Point(149, 281);
            studentInformationFormClassLabel.Name = "studentInformationFormClassLabel";
            studentInformationFormClassLabel.Size = new Size(114, 31);
            studentInformationFormClassLabel.TabIndex = 13;
            studentInformationFormClassLabel.Text = "职    称：";
            // 
            // studentInformationFormAgeLabel
            // 
            studentInformationFormAgeLabel.AutoSize = true;
            studentInformationFormAgeLabel.Location = new Point(137, 207);
            studentInformationFormAgeLabel.Name = "studentInformationFormAgeLabel";
            studentInformationFormAgeLabel.Size = new Size(134, 31);
            studentInformationFormAgeLabel.TabIndex = 12;
            studentInformationFormAgeLabel.Text = "账号密码：";
            // 
            // studentInformationFormStudentNumberLabel
            // 
            studentInformationFormStudentNumberLabel.AutoSize = true;
            studentInformationFormStudentNumberLabel.Location = new Point(137, 113);
            studentInformationFormStudentNumberLabel.Name = "studentInformationFormStudentNumberLabel";
            studentInformationFormStudentNumberLabel.Size = new Size(116, 31);
            studentInformationFormStudentNumberLabel.TabIndex = 11;
            studentInformationFormStudentNumberLabel.Text = "教师姓名:";
            // 
            // studentInformationFormUsernameLabel
            // 
            studentInformationFormUsernameLabel.AutoSize = true;
            studentInformationFormUsernameLabel.Location = new Point(137, 30);
            studentInformationFormUsernameLabel.Name = "studentInformationFormUsernameLabel";
            studentInformationFormUsernameLabel.Size = new Size(134, 31);
            studentInformationFormUsernameLabel.TabIndex = 10;
            studentInformationFormUsernameLabel.Text = "教师工号：";
            studentInformationFormUsernameLabel.Click += studentInformationFormUsernameLabel_Click;
            // 
            // teachersInformationForm1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 488);
            Controls.Add(studentInformationFormCancelButton);
            Controls.Add(studentInformationFormSaveButton);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(studentInformationFormClassLabel);
            Controls.Add(studentInformationFormAgeLabel);
            Controls.Add(studentInformationFormStudentNumberLabel);
            Controls.Add(studentInformationFormUsernameLabel);
            Name = "teachersInformationForm1";
            Text = "教师信息";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button studentInformationFormCancelButton;
        private Button studentInformationFormSaveButton;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label studentInformationFormClassLabel;
        private Label studentInformationFormAgeLabel;
        private Label studentInformationFormStudentNumberLabel;
        private Label studentInformationFormUsernameLabel;
    }
}