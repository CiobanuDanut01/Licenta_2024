using System.Data;
using System.Diagnostics;

namespace Licenta
{
    public partial class OrdersForm : Form
    {
        SqlStuff sql;
        private DataTable dt = new DataTable();
        private string code = string.Empty;
        private Size small = new Size(860, 200);
        private Size big = new Size(800, 520);
        public OrdersForm(SqlStuff sql)
        {
            InitializeComponent();
            this.sql = sql;
            this.code = sql.getCode();
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
        }

        private void Show()
        {
            this.Size = this.big;
            btnView.Visible = true;
            btnDelete.Visible = true;
            dataGridView1.Visible = true;
            lblMissing.Visible = false;
        }

        private void Hide()
        {
            this.Size = this.small;
            btnView.Visible = false;
            btnDelete.Visible = false;
            dataGridView1.Visible = false;
            lblMissing.Visible = true;
        }

        private void getDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Numar comanda");
            dt.Columns.Add("Nume societate");
            dt.Columns.Add("Data comenzii");
            dt.Columns.Add("Valoare");
            this.dt = dt;
        }

        private void addInitialFiles()
        {
            Order order = new Order();
            int count = 0;
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            documentsPath = documentsPath + @"\Documente Aplicatie Management";
            string[] files = System.IO.Directory.GetFiles(documentsPath);
            foreach (string file in files)
            {
                string document = Path.GetFileName(file);
                string prefix = this.code;
                string extensie = ".pdf";

                if (document.StartsWith(prefix + "_Comanda_") && document.EndsWith(extensie))
                {
                    count++;
                    string numereText = document.Substring(prefix.Length + "_Comanda_".Length,
                        document.Length - prefix.Length - "_Comanda_".Length - extensie.Length);
                    bool isOnlyNumbers = OnlyNumbers(numereText);
                    if (isOnlyNumbers)
                    {
                        order = sql.orders.ElementAt(int.Parse(numereText) - 1);
                        this.dt.Rows.Add(order.nr, order.companyName, order.date, order.value);
                    }
                }
            }
            if (count == 0)
            {
                Hide();
                lblMissing.Text = "Nu a fost gasita nici o comanda pe dispozitiv!\nVa rugam creati una sau verificati folderul!";
            }
            else
            {
                Show();
            }
        }

        static bool OnlyNumbers(string text)
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

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard formDash = new Dashboard(sql);
            formDash.Show();
            this.Hide();
        }

        private void acceptChanges()
        {
            List<Order> temp = new List<Order>();
            foreach (DataRow row in dt.Rows)
            {
                Order order = new Order();
                order.nr = row["Numar comanda"].ToString();
                order.companyName = row["Nume societate"].ToString();
                order.date = row["Data comenzii"].ToString();
                order.value = row["Valoare"].ToString();
                temp.Add(order);
            }
            sql.orders = temp;
            sql.updateOrders();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            string fileName = this.code + "_Comanda_" + (idx + 1) + ".pdf";
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
            int idx = dataGridView1.CurrentCell.RowIndex;
            string fileName = this.code + "_Comanda_" + (idx + 1) + ".pdf";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            documentsPath = documentsPath + @"\Documente Aplicatie Management";
            string filePath = documentsPath + @"\" + fileName;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                this.dt.Rows.RemoveAt(idx);
            }
        }
    }
}
