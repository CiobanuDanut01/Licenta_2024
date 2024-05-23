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
    public partial class TemplatesEditForm : Form
    {
        private SqlStuff sql;
        private string code;

        private string name;
        private string regCom;
        private string cif;
        private string address;
        private string iban;
        private string bank;

        public TemplatesEditForm(SqlStuff sql)
        {
            InitializeComponent();
            this.sql = sql;
            this.code = sql.getCode();
            getTemplatesList();
            cboxTemplates.SelectedItem = "Nicio selectie";
        }

        private void getTemplatesList()
        {
            List<TemplateCompanies> list = new List<TemplateCompanies>();
            list = sql.templates;
            cboxTemplates.Items.Clear();
            cboxTemplates.Items.Add("Nicio selectie");
            foreach (TemplateCompanies item in list)
            {
                cboxTemplates.Items.Add(item.name);
            }
        }
        private bool checkEmpty()
        {
            if (txtFirma.Text == "" || txtRegCom.Text == "" || txtCif.Text == "" || txtAdress.Text == "" ||
                txtIban.Text == "" || txtBank.Text == "")
            {
                return false;
            }
            return true;
        }

        private void cboxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTemplates.SelectedIndex != 0)
            {
                TemplateCompanies template = sql.templates.Find(x => x.name == cboxTemplates.SelectedItem.ToString());
                txtFirma.Text = template.name;
                txtRegCom.Text = template.regCom;
                txtCif.Text = template.cif;
                txtAdress.Text = template.address;
                txtIban.Text = template.iban;
                txtBank.Text = template.bank;
            }
            if (cboxTemplates.SelectedIndex == 0)
            {
                clearFields();
            }
        }

        private void clearFields()
        {
            txtFirma.Text = "";
            txtRegCom.Text = "";
            txtCif.Text = "";
            txtAdress.Text = "";
            txtIban.Text = "";
            txtBank.Text = "";
        }

        private void txtFirma_TextChanged(object sender, EventArgs e)
        {
            this.name = txtFirma.Text;
        }

        private void txtRegCom_TextChanged(object sender, EventArgs e)
        {
            this.regCom = txtRegCom.Text;
        }

        private void txtCif_TextChanged(object sender, EventArgs e)
        {
            this.cif = txtCif.Text;
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            this.address = txtAdress.Text;
        }

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            this.iban = txtIban.Text;
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            this.bank = txtBank.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                TemplateCompanies template = new TemplateCompanies();
                template.name = name;
                template.regCom = regCom;
                template.cif = cif;
                template.address = address;
                template.iban = iban;
                template.bank = bank;
                sql.templates.Add(template);
                sql.updateTemplates();
                getTemplatesList();
            }
            else
            {
                MessageBox.Show("Completati toate campurile !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                TemplateCompanies template = sql.templates.Find(x => x.name == cboxTemplates.SelectedItem.ToString());
                sql.templates.Remove(template);
                sql.updateTemplates();
                getTemplatesList();
                clearFields();
            }
            else
            {
                MessageBox.Show("Selectati un sablon pentru a-l sterge ! !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TemplatesEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard formDash = new Dashboard(sql);
            formDash.Show();
            this.Hide();
        }
    }
}
