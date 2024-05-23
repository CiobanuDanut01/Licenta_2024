using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Licenta
{
    public partial class InvoicesAddForm : Form
    {

        #region Date HTML

        private string numeFirma;
        private string regComFirma;
        private string cifFirma;
        private string adresaFirma;
        private string ibanFirma;
        private string numeBancaFirma;
        private string dataFactura;
        private string titluProdusFactura;
        private string detaliiProdusFactura;
        private string unitMas;
        private string cantitate;
        private string pretUnitar;
        private string pretFaraTva;
        private string valoareTva;
        private string pretTotal;
        private string moneda;
        private string nrAuto;
        private string dataPlata;
        private string cotaTva;

        #endregion


        private SqlStuff sql;
        private UserData userData = new UserData();
        private bool isTemplateSaving;
        private string html;
        private string nrZile;
        private int index;

        public InvoicesAddForm(SqlStuff sql)
        {
            InitializeComponent();
            this.isTemplateSaving = false;
            this.sql = sql;
            getTemplatesList();
            cboxTemplates.SelectedIndex = 0;
            this.userData = sql.getUserData();
            this.index = sql.invoices.Count + 1;
            txtCotaTva.Text = "19";
            this.dataFactura = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
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

        private void InvoicesAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.isTemplateSaving)
            {
                if (checkEmpty())
                {
                    DialogResult dialogResult = MessageBox.Show("Doriti sa salvati sablonul?", "Salvare sablon",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TemplateCompanies template = new TemplateCompanies();
                        template.name = txtFirma.Text;
                        template.regCom = txtRegCom.Text;
                        template.cif = txtCif.Text;
                        template.address = txtAdress.Text;
                        template.iban = txtIban.Text;
                        template.bank = txtBank.Text;
                        sql.templates.Add(template);
                        sql.updateTemplates();
                    }
                }
                else
                {
                    MessageBox.Show("Completati toate campurile pentru a salva un sablon!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        #region Metode campuri
        private void txtFirma_TextChanged(object sender, EventArgs e)
        {
            this.numeFirma = txtFirma.Text;
        }

        private void txtRegCom_TextChanged(object sender, EventArgs e)
        {
            this.regComFirma = txtRegCom.Text;
        }

        private void txtCif_TextChanged(object sender, EventArgs e)
        {
            this.cifFirma = txtCif.Text;
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            this.adresaFirma = txtAdress.Text;
        }

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            this.ibanFirma = txtIban.Text;
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            this.numeBancaFirma = txtBank.Text;
        }

        private void chkboxSaveTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSaveTemplate.Checked)
            {
                this.isTemplateSaving = true;
            }
            else
            {
                this.isTemplateSaving = false;
            }
        }

        private void dtInvoice_ValueChanged(object sender, EventArgs e)
        {
            if (dtInvoice.Value > DateTime.Now)
            {
                MessageBox.Show("Data facturii nu poate fi mai mare decat data curenta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtInvoice.Value = DateTime.Now;
            }
            this.dataFactura = dtInvoice.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void txtDueDays_TextChanged(object sender, EventArgs e)
        {
            this.nrZile = txtDueDays.Text;
        }

        private void txtMeasUnit_TextChanged(object sender, EventArgs e)
        {
            this.unitMas = txtMeasUnit.Text;
        }

        private void txtAutoNumber_TextChanged(object sender, EventArgs e)
        {
            this.nrAuto = txtAutoNumber.Text;
        }

        private void txtProdInfo_TextChanged(object sender, EventArgs e)
        {
            this.detaliiProdusFactura = addSpace(txtProdInfo.Text);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            this.cantitate = txtQuantity.Text;
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            this.pretUnitar = txtUnitPrice.Text;
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {
            this.moneda = txtCurrency.Text;
        }

        private void txtCotaTva_TextChanged(object sender, EventArgs e)
        {
            this.cotaTva = txtCotaTva.Text;
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
                txtFirma.Text = "";
                txtRegCom.Text = "";
                txtCif.Text = "";
                txtAdress.Text = "";
                txtIban.Text = "";
                txtBank.Text = "";
            }
        }

        #endregion

        private bool checkAll()
        {
            if (txtFirma.Text == "" || txtRegCom.Text == "" || txtCif.Text == "" || txtAdress.Text == "" ||
                txtIban.Text == "" || txtBank.Text == "" || txtProdInfo.Text == "" || txtQuantity.Text == "" ||
                txtUnitPrice.Text == "" || txtCurrency.Text == "" || txtCotaTva.Text == "" || txtMeasUnit.Text == "" ||
                txtAutoNumber.Text == "" || txtDueDays.Text == "" || !int.TryParse(txtDueDays.Text, out _) ||
                !int.TryParse(txtQuantity.Text, out _) || !int.TryParse(txtUnitPrice.Text, out _) ||
                !int.TryParse(txtCotaTva.Text, out _))
            {
                return false;
            }
            return true;
        }

        private bool isNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private void readHtml()
        {
            string dataPlata = string.Empty;
            int zileDeAdaugat;
            if (!int.TryParse(nrZile, out zileDeAdaugat))
            {
                MessageBox.Show("Numarul de zile nu poate fi parsat!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime data;
            if (DateTime.TryParseExact(dataFactura, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
            {
                DateTime dataModificata = data.AddDays(zileDeAdaugat);
                dataPlata = dataModificata.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            html = System.IO.File.ReadAllText(@"D:/Facultate/LICENTA/Licenta/factura.html");
            html = html.Replace("{numeFirma}", numeFirma);
            html = html.Replace("{regComFirma}", regComFirma);
            html = html.Replace("{cifFirma}", cifFirma);
            html = html.Replace("{adresaFirma}", adresaFirma);
            html = html.Replace("{ibanFirma}", ibanFirma);
            html = html.Replace("{numeBancaFirma}", numeBancaFirma);
            html = html.Replace("{numeFirmaProprie}", userData.name);
            html = html.Replace("{regComFirmaProprie}", userData.regCom);
            html = html.Replace("{cifFirmaProprie}", userData.cif);
            html = html.Replace("{adresaFirmaProprie}", userData.address);
            html = html.Replace("{ibanFirmaProprie}", userData.iban);
            html = html.Replace("{numeBancaFirmaProprie}", userData.bank);
            html = html.Replace("{mailFirmaProprie}", userData.email);
            html = html.Replace("{serieNumarFactura}", "F" + index);
            html = html.Replace("{dataFactura}", dataFactura);
            html = html.Replace("{titluProdusFactura}", titluProdusFactura);
            html = html.Replace("{detaliiProdusFactura}", detaliiProdusFactura);
            html = html.Replace("{unitMas}", unitMas);
            html = html.Replace("{cantitate}", cantitate);
            html = html.Replace("{pretUnitar}", pretUnitar);
            html = html.Replace("{pretFaraTva}", (Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate)).ToString());
            html = html.Replace("{valoareTva}", (Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate) * Convert.ToDouble(cotaTva) / 100).ToString());
            html = html.Replace("{pretTotal}", (Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate) + Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate) * Convert.ToDouble(cotaTva) / 100).ToString());
            html = html.Replace("{moneda}", moneda);
            html = html.Replace("{nrAuto}", nrAuto);
            html = html.Replace("{dataPlata}", dataPlata);
            html = html.Replace("{cotaTva}", cotaTva);
        }

        private string addSpace(string input)
        {
            string output = string.Empty;
            output = input.Replace("\r\n", "<br>");
            return output;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double valoareTotala, valoareTvaTotal, valoareTotalaFaraTva;
            if (this.pretUnitar != "" && this.cantitate != "" && this.cotaTva != "")
            {
                if (isNumeric(pretUnitar) && isNumeric(cantitate) && isNumeric(cotaTva))
                {
                    valoareTotalaFaraTva = Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate);
                    valoareTvaTotal = valoareTotalaFaraTva * Convert.ToDouble(cotaTva) / 100;
                    valoareTotala = valoareTotalaFaraTva + valoareTvaTotal;
                    lblPretFinal.Text = "Pretul final este " + valoareTotala.ToString() + " " + this.moneda +
                                        " adica:\n" + valoareTotalaFaraTva.ToString() + " " +
                                        this.moneda + " + " + valoareTvaTotal.ToString() + " " + this.moneda + " TVA";
                }
                else
                {
                    MessageBox.Show("Introduceti doar valori numerice!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Completati toate campurile pentru a calcula pretul total!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void createPdf()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            path = path + @"\Documente Aplicatie Management";
            System.IO.Directory.CreateDirectory(path);
            string fileName = path + @"\" + userData.code + "_Factura_F" + index.ToString() + ".pdf";
            readHtml();
            if (html != null)
            {
                var converter = new HtmlToPdfConverter();
                converter.ConvertHtmlToPdf(html, fileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkAll())
            {
                MessageBox.Show("Completati toate campurile sau verificati ca valorile numerice sa contina doar cifre!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                createPdf();
                Invoice invoice = new Invoice();
                invoice.nr = "F" + index.ToString();
                invoice.companyName = numeFirma;
                invoice.date = dataFactura;
                invoice.value = (Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate)).ToString();
                invoice.valueTVA = (Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate) * Convert.ToDouble(cotaTva) / 100).ToString();
                invoice.valueTotal = (Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate) + Convert.ToDouble(pretUnitar) * Convert.ToDouble(cantitate) * Convert.ToDouble(cotaTva) / 100).ToString();
                invoice.currency = moneda;
                invoice.checkValues();
                sql.invoices.Add(invoice);
                sql.updateInvoices();
                MessageBox.Show("Factura salvata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.Close();
            }
        }


    }
}
