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
    public partial class DriverForm : Form
    {
        public static SqlStuff sql = new SqlStuff();
        private DataTable dt = new DataTable();
        public DriverForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            sql.getDrivers();
            getDataTable();
            addInitialValues();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
                this.dt.Rows.Add(driver.cnp, driver.name, driver.surname, driver.birthDate, driver.employDate, driver.drivingCat, driver.phone, driver.wage);
            }
        }

        private void DriverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard formDash = new Dashboard();
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
            sql.drivers = temp;
        }
    }
}
