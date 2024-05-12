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
        public Dashboard(SqlStuff sql)
        {
            InitializeComponent();
            this.sql = sql;
            sql.getDrivers();
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
    }
}
