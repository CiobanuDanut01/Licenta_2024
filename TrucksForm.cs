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
    public partial class TrucksForm : Form
    {
        private SqlStuff sql;
        private DataTable dt = new DataTable();
        public List<string> brands = new List<string>();
        public List<string> models = new List<string>();
        public List<string> years = new List<string>();
        public bool isEdited;
        private string?[] filtre = { "~", "~", "~" };
        private string?[] nume = { "Marca", "Model", "An" };

        public TrucksForm(SqlStuff sql)
        {
            InitializeComponent();
            this.sql = sql;
            isEdited = false;
            dt.Clear();
            getDataTable();
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


        private void TrucksForm_Load(object sender, EventArgs e)
        {
            getBrands();
            getModels();
            getYears();
        }

        public void getBrands()
        {
            List<Truck> trucks = sql.trucks;
            brands.Clear();
            brands.Add("~");
            foreach (Truck truck in trucks)
            {
                if (!brands.Contains(truck.brand))
                {
                    brands.Add(truck.brand);
                }
            }
            cboxBrand.DataSource = brands;
            cboxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void getModels()
        {
            List<Truck> trucks = sql.trucks;
            models.Clear();
            models.Add("~");
            foreach (Truck truck in trucks)
            {
                if (!models.Contains(truck.model))
                {
                    models.Add(truck.model);
                }
            }
            cboxModel.DataSource = models;
            cboxModel.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void getYears()
        {
            List<Truck> trucks = sql.trucks;
            years.Clear();
            years.Add("~");
            foreach (Truck truck in trucks)
            {
                if (!years.Contains(truck.year))
                {
                    years.Add(truck.year);
                }
            }
            cboxYear.DataSource = years;
            cboxYear.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void getDataTable()
        {
            if (this.dt.Columns.Count == 0)
            {
                this.dt.Columns.Add("Nr. Inmatriculare", typeof(string));
                this.dt.Columns.Add("Marca", typeof(string));
                this.dt.Columns.Add("Model", typeof(string));
                this.dt.Columns.Add("An", typeof(string));
                this.dt.Columns.Add("Data valabilitate Vinieta", typeof(string));
                this.dt.Columns.Add("Data valabilitate ITP", typeof(string));
                this.dt.Columns.Add("Data valabilitate Asigurare", typeof(string));
                this.dt.Columns.Add("Sofer", typeof(string));
            }
        }

        public void addInitialValues()
        {
            dt.Clear();
            sql.getTrucks();
            foreach (Truck truck in sql.trucks)
            {
                this.dt.Rows.Add(truck.plate, truck.brand, truck.model, truck.year, truck.vigDate, truck.itpDate, truck.rcaDate, truck.driverName);
            }
        }

        private void acceptChanges()
        {
            List<Truck> temp = new List<Truck>();
            foreach (DataRow row in dt.Rows)
            {
                Truck truck = new Truck();
                truck.plate = row["Nr. Inmatriculare"].ToString();
                truck.brand = row["Marca"].ToString();
                truck.model = row["Model"].ToString();
                truck.year = row["An"].ToString();
                truck.vigDate = row["Data valabilitate Vinieta"].ToString();
                truck.itpDate = row["Data valabilitate ITP"].ToString();
                truck.rcaDate = row["Data valabilitate Asigurare"].ToString();
                truck.driverName = row["Sofer"].ToString();
                truck.checkValues();

                while (!truck.isDataCorrect)
                {
                    DialogResult dialogResult = MessageBox.Show("Datele introduse pentru camionul cu numarul de inmatriculare " + truck.plate + " sunt incorecte sau incomplete! Datele trebuie corectate!",
                                                   "Eroare T01", MessageBoxButtons.OK);
                    using (var formTruckEdit = new TruckEditForm(truck))
                    {
                        var result = formTruckEdit.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            truck = formTruckEdit.Truck;
                            row["Nr. Inmatriculare"] = truck.plate;
                            row["Marca"] = truck.brand;
                            row["Model"] = truck.model;
                            row["An"] = truck.year;
                            row["Data valabilitate Vinieta"] = truck.vigDate;
                            row["Data valabilitate ITP"] = truck.itpDate;
                            row["Data valabilitate Asigurare"] = truck.rcaDate;
                            row["Sofer"] = truck.driverName;

                            truck.checkValues();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                temp.Add(truck);
            }
            sql.trucks.Clear();
            sql.trucks = temp;
            sql.updateTrucks();
            sql.getTrucks();
        }

        private void cboxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMessage(isEdited);
            ComboBox comboBox = (ComboBox)sender;
            filtre[0] = (string?)cboxBrand.SelectedItem;
            addInitialValues();
            deleteRows(filtre);
        }

        private void cboxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMessage(isEdited);
            ComboBox comboBox = (ComboBox)sender;
            filtre[1] = (string?)cboxModel.SelectedItem;
            addInitialValues();
            deleteRows(filtre);
        }

        private void cboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMessage(isEdited);
            ComboBox comboBox = (ComboBox)sender;
            filtre[2] = (string?)cboxYear.SelectedItem;
            addInitialValues();
            deleteRows(filtre);
        }

        private void deleteRows(string?[] filtre)
        {
            int i = 0;
            foreach (string? filtru in filtre)
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                var denumire = nume[i];
                foreach (DataRow row in dt.Rows)
                {
                    if (row[denumire].ToString() != filtru && filtru != "~")
                    {
                        rowsToDelete.Add(row);
                    }
                }
                foreach (DataRow row in rowsToDelete)
                {
                    dt.Rows.Remove(row);
                }
                i++;
            }
            dt.AcceptChanges();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isEdited = true;
        }

        private void showMessage(bool isEdited)
        {
            if (isEdited)
            {
                DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte de filtrare?",
                                       "Salvare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    acceptChanges();
                    this.isEdited = false;
                }
            }
        }

        private void txtbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            addInitialValues();
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
                    if (!(row["Nr. Inmatriculare"].ToString().ToLower().Contains(searchText) ||
                          row["Marca"].ToString().ToLower().Contains(searchText) ||
                          row["Model"].ToString().ToLower().Contains(searchText) ||
                          row["An"].ToString().ToLower().Contains(searchText) ||
                          row["Data valabilitate Vinieta"].ToString().ToLower().Contains(searchText) ||
                          row["Data valabilitate ITP"].ToString().ToLower().Contains(searchText) ||
                          row["Data valabilitate Asigurare"].ToString().ToLower().Contains(searchText) ||
                          row["Sofer"].ToString().ToLower().Contains(searchText)))
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
            cboxModel.SelectedIndex = 0;
            cboxYear.SelectedIndex = 0;
            cboxBrand.SelectedIndex = 0;
            txtbxSearch.Text = "";
        }

        private void TrucksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isEdited)
            {
                DialogResult dialogResult = MessageBox.Show("Doriti sa salvati modificarile inainte sa inchideti?",
                                       "Salvare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    acceptChanges();
                }
            }
            Dashboard formDash = new Dashboard(sql);
            formDash.Show();
            this.Hide();
        }
    }
}
