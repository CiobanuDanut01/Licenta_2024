using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Licenta
{
    public partial class InvoicesForm : Form
    {
        private Mail mail = new Mail();
        private SqlStuff sql;
        private UserData userData = new UserData();
        private DataTable dt = new DataTable();
        private string code;
        private Size minimal = new Size(900, 200);
        private Size small = new Size(900, 535);
        private Size big = new Size(900, 600);

        private string mailTo = string.Empty;

        private void Show()
        {
            this.Size = this.big;
            label1.Visible = true;
            txtboxMail.Visible = true;
            btnSendMail.Visible = true;
            dataGridView1.Visible = true;
            btnRefresh.Visible = true;
            btnView.Visible = true;
            btnDelete.Visible = true;
        }

        private void Hide()
        {
            this.Size = this.small;
            chkboxEmail.Visible = true;
            label1.Visible = false;
            txtboxMail.Visible = false;
            btnSendMail.Visible = false;
            dataGridView1.Visible = true;
            btnRefresh.Visible = true;
            btnView.Visible = true;
            btnDelete.Visible = true;
        }

        private void HideAll()
        {
            this.Size = this.minimal;
            chkboxEmail.Visible = false;
            label1.Visible = false;
            txtboxMail.Visible = false;
            btnSendMail.Visible = false;
            dataGridView1.Visible = false;
            btnRefresh.Visible = false;
            btnView.Visible = false;
            btnDelete.Visible = false;
        }
        public InvoicesForm(SqlStuff sql)
        {
            InitializeComponent();
            Hide();
            this.sql = sql;
            this.code = sql.getCode();
            userData = sql.getUserData();
            dt.Clear();
            getDataTable();
            addInitialFiles();
            dataGridView1.DataSource = dt;
            dataGridView1.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };

            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.btnRefresh, "Verifica daca s-au modificat fisierele si reincarca continutul tabelei.");

        }

        private void getDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nr. factura", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Firma", typeof(string));
            dt.Columns.Add("Valoare", typeof(string));
            dt.Columns.Add("Valoare TVA", typeof(string));
            dt.Columns.Add("Valoare totala", typeof(string));
            dt.Columns.Add("Moneda", typeof(string));
            this.dt = dt;
        }

        private void addInitialFiles()
        {
            Invoice invoice = new Invoice();
            dt.Clear();
            int count = 0;
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            documentsPath = documentsPath + @"\Documente Aplicatie Management";
            string[] files = System.IO.Directory.GetFiles(documentsPath);
            foreach (string file in files)
            {
                string document = Path.GetFileName(file);
                string prefix = this.code;
                string extensie = ".pdf";

                if (document.StartsWith(prefix + "_Factura_") && document.EndsWith(extensie))
                {
                    count++;
                    string numereText = document.Substring(prefix.Length + "_Factura_".Length,
                        document.Length - prefix.Length - "_Factura_".Length - extensie.Length);
                    bool isOnlyNumbers = OnlyNumbersAndF(numereText);
                    if (isOnlyNumbers)
                    {
                        invoice = sql.invoices.Find(x => x.nr == numereText);
                        this.dt.Rows.Add(invoice.nr, invoice.companyName, invoice.date, invoice.value, invoice.valueTVA, invoice.valueTotal, invoice.currency);
                    }
                }
            }
            if (count == 0)
            {
                HideAll();
                lblMissing.Text = "Nu a fost gasita nici o factura pe dispozitiv!\nVa rugam creati una sau verificati folderul!";
            }
            else
            {
                Show();
            }
        }

        static bool OnlyNumbersAndF(string text)
        {
            string pattern = @"^F\d+$";

            return Regex.IsMatch(text, pattern);
        }

        private void chkboxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxEmail.Checked)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }

        private void txtboxMail_TextChanged(object sender, EventArgs e)
        {
            this.mailTo = txtboxMail.Text;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (mailTo != string.Empty)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Nr. factura"].Value);
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
                documentsPath = documentsPath + @"\Documente Aplicatie Management";
                string file = documentsPath + @"\" + this.code + "_Factura_" + cellValue + ".pdf";
                var invoice = sql.invoices.Find(x => x.nr == cellValue);
                if (IsValidEmail(mailTo))
                {
                    string subject = "Factura " + invoice.nr;
                    string body = "Factura " + invoice.nr + " din data de " + invoice.date + " pentru " + invoice.companyName + " in valoare de " + invoice.valueTotal + " " + invoice.currency;
                    body += " a fost emisa.\n\nVa multumim pentru colaborare!\n" + this.userData.name;
                    string attachment = file;
                    mail.sendMail(mailTo, subject, body, attachment);
                    MessageBox.Show("Factura a fost trimisa cu succes catre " + this.mailTo, "Informare trimitere MAIL",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adresa de email invalida!", "Eroare trimitere MAIL",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Introduceti o adresa de email!", "Eroare trimitere MAIL",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            addInitialFiles();
            Hide();
            chkboxEmail.CheckState = CheckState.Unchecked;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Nr. factura"].Value);
            string fileName = this.code + "_Factura_" + cellValue + ".pdf";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            documentsPath = documentsPath + @"\Documente Aplicatie Management";
            string filePath = documentsPath + @"\" + fileName;
            OpenWithDefaultProgram(filePath);
        }
        public static void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Nr. factura"].Value);
            string fileName = this.code + "_Factura_" + cellValue + ".pdf";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            documentsPath = documentsPath + @"\Documente Aplicatie Management";
            string filePath = documentsPath + @"\" + fileName;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                this.dt.Rows.RemoveAt(selectedrowindex);
            }
            acceptChanges();
        }
        private void acceptChanges()
        {
            List<Invoice> temp = new List<Invoice>();
            foreach (DataRow row in dt.Rows)
            {
                Invoice invoice = new Invoice();
                invoice.nr = row["Nr. factura"].ToString();
                invoice.companyName = row["Firma"].ToString();
                invoice.date = row["Data"].ToString();
                invoice.value = row["Valoare"].ToString();
                invoice.valueTVA = row["Valoare TVA"].ToString();
                invoice.valueTotal = row["Valoare totala"].ToString();
                invoice.currency = row["Moneda"].ToString();
                temp.Add(invoice);
            }
            sql.invoices = temp;
            sql.updateInvoices();
        }

        private void InvoicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard formDash = new Dashboard(sql);
            formDash.Show();
            this.Hide();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            Hide();
            chkboxEmail.CheckState = CheckState.Unchecked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InvoicesAddForm formAdd = new InvoicesAddForm(sql);
            formAdd.Show();
        }
    }
}
