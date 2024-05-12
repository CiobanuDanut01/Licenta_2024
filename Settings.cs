using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class Settings : Form
    {
        private SqlStuff sql;
        private UserData userData = new UserData();
        private string newPass = string.Empty;
        private string currentPass = string.Empty;
        private Size small = new Size(640, 530);
        private Size big = new Size(640, 800);

        public Settings(SqlStuff sql)
        {
            InitializeComponent();
            Hide();
            this.sql = sql;
            this.userData = sql.getUserData();
            txtboxName.Text = userData.name;
            txtboxRegCom.Text = userData.regCom;
            txtboxCIF.Text = userData.cif;
            txtboxAdress.Text = userData.address;
            txtboxIBAN.Text = userData.iban;
            txtboxBank.Text = userData.bank;
            txtboxUsername.Text = userData.username;
            txtboxEmail.Text = userData.email;
        }

        private void Hide()
        {
            this.Size = this.small;
            btnCloseChck.Visible = false;
            btnSaveChck.Visible = false;
            btnSave.Visible = true;
            btnClose.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            txtboxUsername.Visible = false;
            txtboxCurrentPass.Visible = false;
            txtboxNewPass.Visible = false;
            txtboxEmail.Visible = false;
        }

        private void Show()
        {
            this.Size = this.big;
            btnCloseChck.Visible = true;
            btnSaveChck.Visible = true;
            btnSave.Visible = false;
            btnClose.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            txtboxUsername.Visible = true;
            txtboxCurrentPass.Visible = true;
            txtboxNewPass.Visible = true;
            txtboxEmail.Visible = true;
        }

        private void chkboxChangeCred_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxChangeCred.Checked)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }

        private void saveChanges()
        {
            if (chkboxChangeCred.Checked)
            {
                if (txtboxUsername.Text != "" && txtboxCurrentPass.Text != "" && txtboxNewPass.Text != "" &&
                    txtboxName.Text != "" && txtboxRegCom.Text != "" && txtboxCIF.Text != "" &&
                    txtboxAdress.Text != "" && txtboxIBAN.Text != "" && txtboxBank.Text != "")
                {
                    if (txtboxCurrentPass.Text == userData.currentPass)
                    {
                        userData.currentPass = txtboxNewPass.Text;
                        sql.updateUserData(this.userData, newPass, userData.email);
                    }
                    else
                    {
                        MessageBox.Show("Parola curentă introdusă nu este corectă!", "Eroare S01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Completați toate câmpurile!", "Eroare S02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtboxName.Text != "" && txtboxRegCom.Text != "" && txtboxCIF.Text != "" &&
                    txtboxAdress.Text != "" && txtboxIBAN.Text != "" && txtboxBank.Text != "")
                {
                    sql.updateUserData(this.userData, userData.currentPass, userData.email);
                }
                else
                {
                    MessageBox.Show("Completați toate câmpurile!", "Eroare S02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Close()
        {
            DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte sa inchideti?",
                "Salvare", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveChanges();
            }
            //close the form using the inherited method
            base.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChck_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void btnCloseChck_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            userData.name = txtboxName.Text;
        }

        private void txtboxRegCom_TextChanged(object sender, EventArgs e)
        {
            userData.regCom = txtboxRegCom.Text;
        }

        private void txtboxCIF_TextChanged(object sender, EventArgs e)
        {
            userData.cif = txtboxCIF.Text;
        }

        private void txtboxAdress_TextChanged(object sender, EventArgs e)
        {
            userData.address = txtboxAdress.Text;
        }

        private void txtboxIBAN_TextChanged(object sender, EventArgs e)
        {
            userData.iban = txtboxIBAN.Text;
        }

        private void txtboxBank_TextChanged(object sender, EventArgs e)
        {
            userData.bank = txtboxBank.Text;
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {
            userData.username = txtboxUsername.Text;
        }

        private void txtboxCurrentPass_TextChanged(object sender, EventArgs e)
        {
            this.currentPass = txtboxCurrentPass.Text;
        }

        private void txtboxNewPass_TextChanged(object sender, EventArgs e)
        {
            this.newPass = txtboxNewPass.Text;
        }
        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {
            userData.email = txtboxEmail.Text;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard formDash = new Dashboard(sql);
            formDash.Show();
            this.Hide();
        }
    }
}
