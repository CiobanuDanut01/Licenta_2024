namespace Licenta
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin formLog = new frmLogin();
            formLog.Show();
            this.Hide();
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
