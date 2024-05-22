using System.Data;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Licenta
{
    public partial class DriverForm : Form
    {
        public SqlStuff sql = new SqlStuff();
        private DataTable dt = new DataTable();
        public List<string> drivingCats = Drivers.getDrivingCats();
        private string? selectedCat = string.Empty;
        private bool isEdited;
        public DriverForm(SqlStuff sql)
        {
            InitializeComponent();
            this.sql = sql;
            getDataTable();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            isEdited = false;
            cboxDrivingCats.DataSource = drivingCats;
            cboxDrivingCats.DropDownStyle = ComboBoxStyle.DropDownList;
            dt.Clear();
            addInitialValues();
            dataGridView1.DataSource = dt;
            dataGridView1.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }

        public void getDataTable()
        {
            this.dt.Columns.Add("CNP", typeof(string));
            this.dt.Columns.Add("Nume", typeof(string));
            this.dt.Columns.Add("Prenume", typeof(string));
            this.dt.Columns.Add("Data nasterii", typeof(string));
            this.dt.Columns.Add("Data angajarii", typeof(string));
            this.dt.Columns.Add("Categorii permis", typeof(string));
            this.dt.Columns.Add("Telefon", typeof(string));
            this.dt.Columns.Add("Salariu", typeof(string));
        }

        public void addInitialValues()
        {
            foreach (Drivers driver in sql.drivers)
            {
                this.dt.Rows.Add(driver.cnp, driver.name, driver.surname,
                    driver.birthDate, driver.employDate, driver.drivingCat, driver.phone, driver.wage);
            }
        }

        private void DriverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isEdited)
            {
                DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte sa inchideti?",
                    "Salvare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    acceptChanges();
                    isEdited = false;
                }
            }

            Dashboard formDash = new Dashboard(sql);
            formDash.Show();
            this.Hide();
        }

        private void acceptChanges()
        {
            List<Drivers> temp = new List<Drivers>();
            foreach (DataRow row in dt.Rows)
            {
                Drivers driver = new Drivers();
                driver.cnp = row["CNP"].ToString();
                driver.name = row["Nume"].ToString();
                driver.surname = row["Prenume"].ToString();
                driver.birthDate = row["Data nasterii"].ToString();
                driver.employDate = row["Data angajarii"].ToString();
                driver.drivingCat = row["Categorii permis"].ToString();
                driver.phone = row["Telefon"].ToString();
                driver.wage = row["Salariu"].ToString();
                driver.checkValues();
                temp.Add(driver);
            }
            sql.drivers.Clear();
            sql.drivers = temp;
        }

        private void cboxDrivingCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEdited)
            {
                DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte de filtrare?",
                    "Salvare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    acceptChanges();
                    isEdited = false;
                }
            }
            dt.Clear();
            addInitialValues();
            dataGridView1.DataSource = dt;
            ComboBox comboBox = (ComboBox)sender;
            selectedCat = (string?)cboxDrivingCats.SelectedItem;
            if (selectedCat != "~")
            {
                deleteRows();
            }
        }


        private void deleteRows()
        {
            foreach (Drivers driver in sql.drivers)
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                string categorii = driver.drivingCat;
                foreach (DataRow row in dt.Rows)
                {
                    if (!row["Categorii permis"].ToString().ToUpper().Contains(selectedCat))
                    {
                        rowsToDelete.Add(row);
                    }
                }
                foreach (DataRow row in rowsToDelete)
                {
                    dt.Rows.Remove(row);
                }
            }
            dt.AcceptChanges();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isEdited = true;
        }

        private void txtbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isEdited)
                {
                    DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte de cautare?",
                        "Salvare", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        acceptChanges();
                        isEdited = false;
                    }
                }
                TextBox textBox = (TextBox)sender;
                string searchText = textBox.Text.ToLower();
                List<DataRow> rowsToDelete = new List<DataRow>();
                foreach (DataRow row in dt.Rows)
                {
                    if (!(row["CNP"].ToString().ToLower().Contains(searchText) ||
                        row["Nume"].ToString().ToLower().Contains(searchText) ||
                        row["Prenume"].ToString().ToLower().Contains(searchText) ||
                        row["Data nasterii"].ToString().ToLower().Contains(searchText) ||
                        row["Data angajarii"].ToString().ToLower().Contains(searchText) ||
                        row["Telefon"].ToString().ToLower().Contains(searchText) ||
                        row["Salariu"].ToString().ToLower().Contains(searchText)))
                    {
                        rowsToDelete.Add(row);
                    }
                }
                foreach (DataRow row in rowsToDelete)
                {
                    dt.Rows.Remove(row);
                }
                dt.AcceptChanges();
                dataGridView1.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isEdited)
            {
                DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte de resetarea filtrelor?",
                    "Salvare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    acceptChanges();
                    isEdited = false;
                }
            }
            dt.Clear();
            addInitialValues();
            dataGridView1.DataSource = dt;
            cboxDrivingCats.SelectedIndex = 0;
            txtbxSearch.Text = "";
        }
    }
}
