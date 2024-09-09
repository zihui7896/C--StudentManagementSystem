namespace StudentManagementSystem
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            loginButton = new Button();
            unregisterButton = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            permissionsLabel = new Label();
            pictureBox1 = new PictureBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            permissionsComboBox = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(137, 300);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 46);
            loginButton.TabIndex = 0;
            loginButton.Text = "登录";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += login_Click;
            // 
            // unregisterButton
            // 
            unregisterButton.Location = new Point(455, 300);
            unregisterButton.Name = "unregisterButton";
            unregisterButton.Size = new Size(150, 46);
            unregisterButton.TabIndex = 1;
            unregisterButton.Text = "取消";
            unregisterButton.UseVisualStyleBackColor = true;
            unregisterButton.Click += unregister_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(327, 69);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(110, 31);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "用户名：";
            usernameLabel.Click += label1_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(327, 148);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 31);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "密码：";
            // 
            // permissionsLabel
            // 
            permissionsLabel.AutoSize = true;
            permissionsLabel.Location = new Point(327, 229);
            permissionsLabel.Name = "permissionsLabel";
            permissionsLabel.Size = new Size(86, 31);
            permissionsLabel.TabIndex = 4;
            permissionsLabel.Text = "权限：";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(455, 69);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 38);
            usernameTextBox.TabIndex = 6;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(455, 148);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 38);
            passwordTextBox.TabIndex = 8;
            // 
            // permissionsComboBox
            // 
            permissionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            permissionsComboBox.FormattingEnabled = true;
            permissionsComboBox.Items.AddRange(new object[] { "学生", "老师", "管理员" });
            permissionsComboBox.Location = new Point(456, 227);
            permissionsComboBox.Name = "permissionsComboBox";
            permissionsComboBox.Size = new Size(202, 39);
            permissionsComboBox.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 409);
            Controls.Add(permissionsComboBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(permissionsLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(unregisterButton);
            Controls.Add(loginButton);
            Name = "loginForm";
            Text = "登录";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button unregisterButton;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label permissionsLabel;
        private PictureBox pictureBox1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private ComboBox permissionsComboBox;
        private System.Windows.Forms.Timer timer1;
    }
}
