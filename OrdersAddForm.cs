using DinkToPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class OrdersAddForm : Form
    {
        #region Date HTML
        private string numeFirma;
        private string nrComanda;
        private string dataComanda;
        private string NumeFirmaProprie;
        private string regComPropriu;
        private string CIFPropriu;
        private string adresaProprie;
        private string numeSofer;
        private string telefonSofer;
        private string tipCamion;
        private string nrInmatriculareCamion;
        private string nrInmatriculareRemorca;
        private string dataIncarcare;
        private string intervalIncarcare;
        private string adresaCompletaIncarcare;
        private string numePersoanaIncarcare;
        private string nrTelefonIncarcare;
        private string descriereMarfa;
        private string greutateMarfa;
        private string dataDescarcare;
        private string intervalDescarcare;
        private string adresaCompletaDescarcare;
        private string numePersoanaDescarcare;
        private string nrTelefonDescarcare;
        private string valoareComanda;
        private string moneda;
        private string nrZilePlata;

        private string regCom;
        private string cif;
        private string address;
        private string iban;
        private string bank;
        #endregion

        private string code;
        private SqlStuff sql;
        private bool isTemplateSaving;
        private string html;
        private int index;
        private UserData user;

        public OrdersAddForm(SqlStuff sql)
        {
            InitializeComponent();
            this.isTemplateSaving = false;
            this.sql = sql;
            this.code = sql.getCode();
            getTemplatesList();
            cboxTemplates.SelectedIndex = 0;
            this.index = sql.orders.Count + 1;
            this.user = sql.getUserData();
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

        private void OrdersAddForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void cboxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTemplates.SelectedIndex != 0)
            {
                TemplateCompanies template = sql.templates[cboxTemplates.SelectedIndex - 1];
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.isTemplateSaving = true;
            }
            else
            {
                this.isTemplateSaving = false;
            }
        }

        private void dtLoad_ValueChanged(object sender, EventArgs e)
        {
            this.dataIncarcare = dtLoad.Value.ToString("dd/MM/yyyy");
        }

        private void txtLoadHour_TextChanged(object sender, EventArgs e)
        {
            this.intervalIncarcare = txtLoadHour.Text;
        }

        private void txtLoadAdress_TextChanged(object sender, EventArgs e)
        {
            this.adresaCompletaIncarcare = txtLoadAdress.Text;
        }

        private void txtLoadPers_TextChanged(object sender, EventArgs e)
        {
            this.numePersoanaIncarcare = txtLoadPers.Text;
        }

        private void txtLoadPhone_TextChanged(object sender, EventArgs e)
        {
            this.nrTelefonIncarcare = txtLoadPhone.Text;
        }

        private void dtUnload_ValueChanged(object sender, EventArgs e)
        {
            if (dtUnload.Value < dtLoad.Value)
            {
                MessageBox.Show("Data de descarcare nu poate fi inainte de data de incarcare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtUnload.Value = dtLoad.Value;
            }
            else
            {
                this.dataDescarcare = dtUnload.Value.ToString("dd/MM/yyyy");
            }
             
        }

        private void txtUnloadHour_TextChanged(object sender, EventArgs e)
        {
            this.intervalDescarcare = txtUnloadHour.Text;
        }

        private void txtUnloadAdress_TextChanged(object sender, EventArgs e)
        {
            this.adresaCompletaDescarcare = txtUnloadAdress.Text;
        }

        private void txtUnloadPers_TextChanged(object sender, EventArgs e)
        {
            this.numePersoanaDescarcare = txtUnloadPers.Text;
        }

        private void txtUnloadPhone_TextChanged(object sender, EventArgs e)
        {
            this.nrTelefonDescarcare = txtUnloadPhone.Text;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            this.valoareComanda = txtValue.Text;
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {
            this.moneda = txtCurrency.Text;
        }

        private void txtCargoDesc_TextChanged(object sender, EventArgs e)
        {
            this.descriereMarfa = txtCargoDesc.Text;
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            this.nrZilePlata = txtDays.Text;
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            this.greutateMarfa = txtWeight.Text;
        }

        private void txtDriverName_TextChanged(object sender, EventArgs e)
        {
            this.numeSofer = txtDriverName.Text;
        }

        private void txtDriverPhone_TextChanged(object sender, EventArgs e)
        {
            this.telefonSofer = txtDriverPhone.Text;
        }

        private void txtTruckType_TextChanged(object sender, EventArgs e)
        {
            this.tipCamion = txtTruckType.Text;
        }

        private void txtTruckPlate_TextChanged(object sender, EventArgs e)
        {
            this.nrInmatriculareCamion = txtTruckPlate.Text;
        }

        #endregion

        private bool isAllEmpty()
        {
            if (txtFirma.Text == "" || txtRegCom.Text == "" || txtCif.Text == "" || txtAdress.Text == "" ||
                txtIban.Text == "" || txtBank.Text == "" || txtLoadHour.Text == "" ||
                txtLoadAdress.Text == "" | txtLoadPers.Text == "" || txtLoadPhone.Text == "" ||
                txtUnloadHour.Text == "" || txtUnloadAdress.Text == "" ||
                txtUnloadPers.Text == "" || txtUnloadPhone.Text == "" || txtValue.Text == "" ||
                txtCurrency.Text == "" || txtCargoDesc.Text == "" || txtDays.Text == "" ||
                txtWeight.Text == "" || txtDriverName.Text == "" || txtDriverPhone.Text == "" ||
                txtTruckType.Text == "" || txtTruckPlate.Text == "" || !isNumeric(txtValue.Text) ||
                !isNumeric(txtLoadPhone.Text) || !isNumeric(txtUnloadPhone.Text) || !isNumeric(txtWeight.Text) ||
                !isNumeric(txtDays.Text))
            {
                return true;
            }
            return false;
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
            html = System.IO.File.ReadAllText("D:/Facultate/LICENTA/Licenta/comanda.html");
            html = html.Replace("{numeFirma}", numeFirma);
            html = html.Replace("{nrComanda}", nrComanda);
            html = html.Replace("{dataComanda}", dataComanda);
            html = html.Replace("{numeFirmaProprie}", NumeFirmaProprie);
            html = html.Replace("{regComPropriu}", regComPropriu);
            html = html.Replace("{CIFPropriu}", CIFPropriu);
            html = html.Replace("{adresaProprie}", adresaProprie);
            html = html.Replace("{numeSofer}", numeSofer);
            html = html.Replace("{telefonSofer}", telefonSofer);
            html = html.Replace("{tipCamion}", tipCamion);
            html = html.Replace("{nrInmatriculareCamion}", nrInmatriculareCamion);
            html = html.Replace("{nrInmatriculareRemorca}", "");
            html = html.Replace("{dataIncarcare}", dataIncarcare);
            html = html.Replace("{intervalIncarcare}", intervalIncarcare);
            html = html.Replace("{adresaCompletaIncarcare}", adresaCompletaIncarcare);
            html = html.Replace("{numePersoanaIncarcare}", numePersoanaIncarcare);
            html = html.Replace("{nrTelefonIncarcare}", nrTelefonIncarcare);
            html = html.Replace("{descriereMarfa}", descriereMarfa);
            html = html.Replace("{greutateMarfa}", greutateMarfa);
            html = html.Replace("{dataDescarcare}", dataDescarcare);
            html = html.Replace("{intervalDescarcare}", intervalDescarcare);
            html = html.Replace("{adresaCompletaDescarcare}", adresaCompletaDescarcare);
            html = html.Replace("{numePersoanaDescarcare}", numePersoanaDescarcare);
            html = html.Replace("{nrTelefonDescarcare}", nrTelefonDescarcare);
            html = html.Replace("{valoareComanda}", valoareComanda);
            html = html.Replace("{moneda}", moneda);
            html = html.Replace("{nrZilePlata}", nrZilePlata);
        }

        private void createPdf()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            path = path + @"\Documente Aplicatie Management";
            System.IO.Directory.CreateDirectory(path);
            string fileName = path + @"\" + code + "_Comanda_" + nrComanda + ".pdf";
            readHtml();
            if (html != null)
            {
                var converter = new HtmlToPdfConverter();
                converter.ConvertHtmlToPdf(html, fileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAllEmpty())
            {
                MessageBox.Show("Completati toate campurile sau verificati ca valoarea numerice* sa contina doar cifre!" +
                                "\n * -> numere de telefon, zilele de plata, greutatea, pretul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.nrComanda = index.ToString();
                this.dataComanda = DateTime.Now.ToString("dd/MM/yyyy");
                this.NumeFirmaProprie = user.name;
                this.regComPropriu = user.regCom;
                this.CIFPropriu = user.cif;
                this.adresaProprie = user.address;
                createPdf();
                Order order = new Order();
                order.nr = nrComanda;
                order.companyName = numeFirma;
                order.date = dataComanda;
                order.value = valoareComanda + " " + moneda;
                sql.orders.Add(order);
                sql.updateOrders();
                MessageBox.Show("Comanda salvata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.Close();
            }
        }


    }
}


