using System.Globalization;

namespace Licenta
{
    public partial class frmLogin : Form
    {
        private Mail mail = new Mail();
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
                sendEmails(this.username);
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

        private void sendEmails(string username)
        {
            sql.getTrucks();
            string email = sql.getMail(username);
            foreach (Truck truck in sql.trucks)
            {
                DateTime parsedDate;
                bool isDate = DateTime.TryParseExact(truck.vigDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

                if (isDate)
                {
                    DateTime currentDate = DateTime.Now;
                    TimeSpan difference = parsedDate - currentDate;

                    if (difference.TotalDays < 0)
                    {
                        MessageBox.Show("Data de valabilitate a vinietei pentru " + truck.plate + " a fost depasita!", "Informare prin MAIL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mail.sendMail(email,"Expirare vinieta " + truck.plate,"Data de valabilitate a vinietei pentru " + truck.plate + " a fost depasita!");
                    }
                    else if (difference.TotalDays <= 7)
                    {
                        MessageBox.Show("Data de valabilitate a vinietei pentru " + truck.plate + " urmeaza sa expire!", "Informare prin MAIL",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mail.sendMail(email,"Expirare vinieta curand " + truck.plate,"Data de valabilitate a vinietei pentru " + truck.plate + " are mai putin de 7 zile pana la expirare!");
                    }
                }
                else
                {
                    MessageBox.Show("Data de valabilitate a vinietei pentru " + truck.plate + " nu este valida!", "Eroare T02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                isDate = DateTime.TryParseExact(truck.itpDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
                if (isDate)
                {
                    DateTime currentDate = DateTime.Now;
                    TimeSpan difference = parsedDate - currentDate;

                    if (difference.TotalDays < 0)
                    {
                        MessageBox.Show("Data de valabilitate a ITP-ului pentru " + truck.plate + " a fost depasita!", "Informare prin MAIL",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mail.sendMail(email,"Expirare ITP " + truck.plate,"Data de valabilitate a ITP-ului pentru " + truck.plate + " a fost depasita!");
                    }
                    else if (difference.TotalDays <= 7)
                    {
                        MessageBox.Show("Data de valabilitate a ITP-ului pentru " + truck.plate + " urmeaza sa expire!", "Informare prin MAIL",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mail.sendMail(email,"Expirare ITP curand " + truck.plate,"Data de valabilitate a ITP-ului pentru " + truck.plate + " are mai putin de 7 zile pana la expirare!");
                    }
                }
                else
                {
                    MessageBox.Show("Data de valabilitate a ITP-ului pentru " + truck.plate + " nu este valida!", "Eroare T02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                isDate = DateTime.TryParseExact(truck.rcaDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
                if (isDate)
                {
                    DateTime currentDate = DateTime.Now;
                    TimeSpan difference = parsedDate - currentDate;

                    if (difference.TotalDays < 0)
                    {
                        MessageBox.Show("Data de valabilitate a RCA-ului pentru " + truck.plate + " a fost depasita!", "Informare prin MAIL",
                                                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mail.sendMail(email,"Expirare RCA " + truck.plate,"Data de valabilitate a RCA-ului pentru " + truck.plate + " a fost depasita!");
                    }
                    else if (difference.TotalDays <= 7)
                    {
                        MessageBox.Show("Data de valabilitate a RCA-ului pentru " + truck.plate + " urmeaza sa expire!", "Informare prin MAIL",
                                                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mail.sendMail(email,"Expirare RCA curand " + truck.plate,"Data de valabilitate a RCA-ului pentru " + truck.plate + " are mai putin de 7 zile pana la expirare!");
                    }
                }
                else
                {
                    MessageBox.Show("Data de valabilitate a RCA-ului pentru " + truck.plate + " nu este valida!", "Eroare T02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
