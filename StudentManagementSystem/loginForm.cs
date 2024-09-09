namespace StudentManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unregister_Click(object sender, EventArgs e)
        {


        }

        private void permissionsTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            permissionsComboBox.Text = "";
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < 280)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                permissionsComboBox.Visible = false;
                usernameTextBox.Visible = false;
                passwordTextBox.Visible = false;
                permissionsLabel.Visible = false;
                loginButton.Visible = false;
                unregisterButton.Visible = false;
            } else
            {
                timer1.Stop();
                studentManagementForm studentManagementForm = new studentManagementForm();
                this.Hide();
                studentManagementForm.Show();
                //Application.ExitThread();
            }
             
        }

        private void login_Click(object sender, EventArgs e)
        {
            if ("1" == usernameTextBox.Text && "1" == passwordTextBox.Text && "学生" == permissionsComboBox.Text)
            {
                timer1.Start();
            } else
            {
                MessageBox.Show("请输入正确的用户名,密码");
            }
            
        }
    }
}
