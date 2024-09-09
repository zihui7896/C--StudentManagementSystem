namespace StudentManagementSystem
{
    partial class studentInformationForm
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
            studentInformationFormUsernameLabel = new Label();
            studentInformationFormStudentNumberLabel = new Label();
            studentInformationFormAgeLabel = new Label();
            studentInformationFormClassLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            studentInformationFormSaveButton = new Button();
            studentInformationFormCancelButton = new Button();
            SuspendLayout();
            // 
            // studentInformationFormUsernameLabel
            // 
            studentInformationFormUsernameLabel.AutoSize = true;
            studentInformationFormUsernameLabel.Location = new Point(94, 66);
            studentInformationFormUsernameLabel.Name = "studentInformationFormUsernameLabel";
            studentInformationFormUsernameLabel.Size = new Size(86, 31);
            studentInformationFormUsernameLabel.TabIndex = 0;
            studentInformationFormUsernameLabel.Text = "姓名：";
            // 
            // studentInformationFormStudentNumberLabel
            // 
            studentInformationFormStudentNumberLabel.AutoSize = true;
            studentInformationFormStudentNumberLabel.Location = new Point(94, 152);
            studentInformationFormStudentNumberLabel.Name = "studentInformationFormStudentNumberLabel";
            studentInformationFormStudentNumberLabel.Size = new Size(68, 31);
            studentInformationFormStudentNumberLabel.TabIndex = 1;
            studentInformationFormStudentNumberLabel.Text = "学号:";
            // 
            // studentInformationFormAgeLabel
            // 
            studentInformationFormAgeLabel.AutoSize = true;
            studentInformationFormAgeLabel.Location = new Point(94, 236);
            studentInformationFormAgeLabel.Name = "studentInformationFormAgeLabel";
            studentInformationFormAgeLabel.Size = new Size(68, 31);
            studentInformationFormAgeLabel.TabIndex = 2;
            studentInformationFormAgeLabel.Text = "年龄:";
            // 
            // studentInformationFormClassLabel
            // 
            studentInformationFormClassLabel.AutoSize = true;
            studentInformationFormClassLabel.Location = new Point(94, 313);
            studentInformationFormClassLabel.Name = "studentInformationFormClassLabel";
            studentInformationFormClassLabel.Size = new Size(68, 31);
            studentInformationFormClassLabel.TabIndex = 3;
            studentInformationFormClassLabel.Text = "班级:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 38);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 38);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 38);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(247, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 38);
            textBox4.TabIndex = 7;
            // 
            // studentInformationFormSaveButton
            // 
            studentInformationFormSaveButton.Location = new Point(94, 418);
            studentInformationFormSaveButton.Name = "studentInformationFormSaveButton";
            studentInformationFormSaveButton.Size = new Size(150, 46);
            studentInformationFormSaveButton.TabIndex = 8;
            studentInformationFormSaveButton.Text = "save";
            studentInformationFormSaveButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationFormCancelButton
            // 
            studentInformationFormCancelButton.Location = new Point(402, 418);
            studentInformationFormCancelButton.Name = "studentInformationFormCancelButton";
            studentInformationFormCancelButton.Size = new Size(150, 46);
            studentInformationFormCancelButton.TabIndex = 9;
            studentInformationFormCancelButton.Text = "cancel";
            studentInformationFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 535);
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
            Name = "studentInformationForm";
            Text = "学生信息";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentInformationFormUsernameLabel;
        private Label studentInformationFormStudentNumberLabel;
        private Label studentInformationFormAgeLabel;
        private Label studentInformationFormClassLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button studentInformationFormSaveButton;
        private Button studentInformationFormCancelButton;
    }
}