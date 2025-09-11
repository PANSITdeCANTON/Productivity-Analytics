namespace Productivity_Analytics
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = usernameLogin.Text;
            String password = passwordLogin.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void passwordLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
