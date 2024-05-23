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
    public partial class Dashboard : Form
    {
        public SqlStuff sql = new SqlStuff();

        public DriverForm formDrivers;
        public Settings formSettings;
        public TrucksForm formTruck;
        public OrdersForm formOrders;
        public InvoicesForm formInvoices;
        public Dashboard(SqlStuff sql)
        {
            InitializeComponent();
            this.sql = sql;
            sql.getDrivers();
            sql.getTrucks();
            sql.getOrders();
            sql.getTemplates();
            sql.getInvoices();
        }

        private void btnSof_Click(object sender, EventArgs e)
        {
            this.formDrivers = new DriverForm(this.sql);
            this.Hide();
            formDrivers.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formSettings = new Settings(this.sql);
            formSettings.Show();
        }

        private void btnTruck_Click(object sender, EventArgs e)
        {
            this.formTruck = new TrucksForm(this.sql);
            this.Hide();
            formTruck.Show();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            this.formOrders = new OrdersForm(this.sql);
            this.Hide();
            formOrders.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formInvoices = new InvoicesForm(this.sql);
            this.Hide();
            formInvoices.Show();
        }
    }
}
