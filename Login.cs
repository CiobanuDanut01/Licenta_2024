namespace Licenta
{
    public partial class frmLogin : Form
    {
        private string username;
        private string password;
        public static SqlStuff sql = new SqlStuff();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmRegister formReg = new frmRegister();
            formReg.Show();
            this.Hide();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            textPassword.Text = "";
            textUsername.Text = "";
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            sql.login(this.username, this.password);
            if (sql.isLoginSucces)
            {
                Dashboard formDash = new Dashboard(sql);
                formDash.Show();
                this.Hide();
            }
        }

        private void textUsername_TextChanged_1(object sender, EventArgs e)
        {
            this.username = textUsername.Text;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = textPassword.Text;
        }
    }
}
