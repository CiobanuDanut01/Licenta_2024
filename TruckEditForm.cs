namespace Licenta
{
    public partial class TruckEditForm : Form
    {
        public Truck Truck { get; private set; }

        public TruckEditForm(Truck truck)
        {
            InitializeComponent();
            Truck = truck;

            txtPlate.Text = Truck.plate;
            txtBrand.Text = Truck.brand;
            txtModel.Text = Truck.model;
            txtYear.Text = Truck.year;
            txtVigDate.Text = Truck.vigDate;
            txtITPDate.Text = Truck.itpDate;
            txtRcaDate.Text = Truck.rcaDate;
            txtDriverName.Text = Truck.driverName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Truck.plate = txtPlate.Text;
            Truck.brand = txtBrand.Text;
            Truck.model = txtModel.Text;
            Truck.year = txtYear.Text;
            Truck.vigDate = txtVigDate.Text;
            Truck.itpDate = txtITPDate.Text;
            Truck.rcaDate = txtRcaDate.Text;
            Truck.driverName = txtDriverName.Text;

            Truck.checkValues();
            if (Truck.isDataCorrect)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Datele introduse sunt incorecte sau incomplete! Vă rugăm să corectați datele.", "Eroare T01");
            }
        }
    }
}
