using MySql.Data.MySqlClient;
namespace Licenta
{
    public partial class frmRegister : Form
    {
        private string username;
        private string password;
        private bool isPassVisible;
        private bool isPassMatch;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            this.username = textUsername.Text;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = textPassword.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=Licenta;uid=root;pwd=Xploz!on726";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string query = "INSERT INTO licenta.login(Username, Pass, Email ) VALUES ('" + this.username + "', '" + this.password + "', 'testdinVS@vs.ro')";
                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Inregistrare cu succes!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare in conectarea la baza de date SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textPassword.Text = "";
            textUsername.Text = "";
            textConPassword.Text = "";
        }

        private void textConPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text != textConPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                this.isPassMatch = false;
            }
            else
            {
                this.isPassMatch = true;
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar=='*')
            {
                btnHidePass.BringToFront();
                textPassword.PasswordChar = '\0';
                textConPassword.PasswordChar = '\0';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar=='\0')
            {
                btnShowPass.BringToFront();
                textPassword.PasswordChar = '*';
                textConPassword.PasswordChar = '*';
            }
        }
    }
}
