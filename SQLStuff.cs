using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Licenta
{
    public class SqlStuff
    {
        private readonly string _conn = "server=localhost;database=Licenta;uid=root;pwd=Xploz!on726";
        public List<Drivers> drivers = new List<Drivers>();
        public bool isLoginSucces;
        public string currentUsername;
        public List<Truck> trucks = new List<Truck>();
        public List<Order> orders = new List<Order>();
        public List<TemplateCompanies> templates = new List<TemplateCompanies>();

        public void register(string username, string password)
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "INSERT INTO licenta.login(Username, Pass, Email ) VALUES ('" + username + "', '" + password + "', 'testdinVS@vs2.ro')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Inregistrare cu succes!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
        public void login(string username, string password)
        {
            this.isLoginSucces = false;
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = string.Empty;
                    this.currentUsername = username;
                    if (username != null && password != null)
                    {
                        query = "SELECT * FROM licenta.login WHERE Username = '" + username.Trim() +
                                       "' AND Pass = '" + password.Trim() + "'";
                    }
                    else
                    {
                        MessageBox.Show("Nu ati completat toate campurile!", "Eroare SQL02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Utilizator gasit!\nLogare cu succes!");
                            this.isLoginSucces = true;
                        }
                        else
                        {
                            MessageBox.Show("Logare esuata!\nDatele nu corespund celor din tabel, incercati sa va inregistrati!", "Eroare SQL03", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public string getMail(string username)
        {
            string email = string.Empty;
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT Email FROM licenta.login WHERE Username = '" + username + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        email = dt.Rows[0]["Email"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }

            return email;
        }

        public void getDrivers()
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT * FROM licenta.drivers";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            Drivers driver = new Drivers();
                            driver.cnp = row["CNP"].ToString();
                            driver.name = row["Name"].ToString();
                            driver.surname = row["Surname"].ToString();
                            driver.birthDate = row["BirthDate"].ToString();
                            driver.employDate = row["EmployDate"].ToString();
                            driver.drivingCat = row["DrivingCat"].ToString();
                            driver.phone = row["Phone"].ToString();
                            driver.wage = row["Wage"].ToString();
                            driver.checkValues();
                            drivers.Add(driver);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public UserData getUserData()
        {
            UserData user = new UserData();
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT * FROM licenta.usersdata WHERE Username = '" + this.currentUsername + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        user.name = dt.Rows[0]["Nume_societate"].ToString();
                        user.regCom = dt.Rows[0]["Reg_Com"].ToString();
                        user.cif = dt.Rows[0]["CIF"].ToString();
                        user.address = dt.Rows[0]["Adresa"].ToString();
                        user.iban = dt.Rows[0]["IBAN"].ToString();
                        user.bank = dt.Rows[0]["Banca"].ToString();
                        user.code = dt.Rows[0]["Cod_Generat"].ToString();
                        user.username = dt.Rows[0]["Username"].ToString();
                        user.currentPass = dt.Rows[0]["Pass"].ToString();
                    }
                    query = "SELECT * FROM licenta.login WHERE Username = '" + this.currentUsername + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        user.email = dt.Rows[0]["Email"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }

            return user;
        }

        public void updateUserData(UserData user, string pass, string email)
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "UPDATE licenta.usersdata SET Nume_societate = '" + user.name + "', Reg_Com = '" +
                                   user.regCom + "', CIF = '" + user.cif + "', Adresa = '" + user.address +
                                   "', IBAN = '" + user.iban + "', Banca = '" + user.bank + "', Cod_Generat = '" +
                                   user.code + "', Username = '" + user.username + "', Pass = '" + pass +
                                   "' WHERE Cod_generat = '" + user.code + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    query = "UPDATE licenta.login SET Username = '" + user.username + "', Pass = '" + pass +
                            "', Email = '" + email + "' WHERE Username = '" + this.currentUsername + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Datele au fost actualizate cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public void getTrucks()
        {
            this.trucks.Clear();
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "select * from licenta.trucks where cod_firma in (select Cod_generat from licenta.usersdata where licenta.usersdata.username = '" + this.currentUsername + "')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            Truck truck = new Truck();
                            truck.plate = row["Nr_inmatriculare"].ToString();
                            truck.brand = row["Marca"].ToString();
                            truck.model = row["Model"].ToString();
                            truck.year = row["An_fab"].ToString();
                            truck.vigDate = row["Data_rovinieta"].ToString();
                            truck.itpDate = row["Data_ITP"].ToString();
                            truck.rcaDate = row["Data_asigurare"].ToString();
                            truck.driverName = row["Nume_sofer"].ToString();
                            truck.checkValues();
                            trucks.Add(truck);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public void updateTrucks()
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query =
                        "DELETE FROM licenta.trucks WHERE cod_firma in (select Cod_generat from licenta.usersdata where licenta.usersdata.username = '" +
                        this.currentUsername + "')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    foreach (Truck truck in trucks)
                    {
                        query =
                            "INSERT INTO licenta.trucks(Nr_inmatriculare, Marca, Model, An_fab, Data_rovinieta, Data_ITP, Data_asigurare, Nume_sofer, Cod_firma) VALUES ('" +
                            truck.plate + "', '" + truck.brand + "', '" + truck.model + "', '" + truck.year + "', '" +
                            truck.vigDate + "', '" + truck.itpDate + "', '" + truck.rcaDate + "', '" +
                            truck.driverName +
                            "', (select Cod_generat from licenta.usersdata where licenta.usersdata.username = '" +
                            this.currentUsername + "'))";
                        using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datele au fost actualizate cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public string getCode()
        {
            string code = string.Empty;
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" +
                                   this.currentUsername + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        code = dt.Rows[0]["Cod_generat"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }

            return code;
        }

        public void getOrders()
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query =
                        "SELECT * FROM licenta.comenzi WHERE Cod_firma = (SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" +
                        this.currentUsername + "')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            Order order = new Order();
                            order.nr = row["Nr_Comanda"].ToString();
                            order.companyName = row["Nume_societate"].ToString();
                            order.date = row["Data_comanda"].ToString();
                            order.value = row["Valoare"].ToString();
                            order.checkValues();
                            orders.Add(order);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public void updateOrders()
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query =
                        "DELETE FROM licenta.comenzi WHERE Cod_firma = (SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" +
                        this.currentUsername + "')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    foreach (Order order in orders)
                    {
                        query =
                            "INSERT INTO licenta.comenzi(Nr_comanda, Nume_societate, Data_comanda, Valoare, Cod_firma) VALUES ('" + order.nr + "', '" + order.companyName + "', '" + order.date + "', '" + order.value +
                            "', (SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" + this.currentUsername +
                            "'))";
                        using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datele au fost actualizate cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public void getTemplates()
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query =
                        "SELECT * FROM licenta.sabloane WHERE Cod_firma = (SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" +
                        this.currentUsername + "')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        templates.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            TemplateCompanies template = new TemplateCompanies();
                            template.name = row["Nume_societate"].ToString();
                            template.regCom = row["Reg_Com"].ToString();
                            template.cif = row["CIF"].ToString();
                            template.address = row["Adresa"].ToString();
                            template.iban = row["IBAN"].ToString();
                            template.bank = row["Banca"].ToString();
                            templates.Add(template);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public void updateTemplates()
        {
            using (MySqlConnection cnn = new MySqlConnection(_conn))
            {
                try
                {
                    cnn.Open();
                    string query =
                        "DELETE FROM licenta.sabloane WHERE Cod_firma = (SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" +
                        this.currentUsername + "')";
                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    foreach (TemplateCompanies template in templates)
                    {
                        query =
                            "INSERT INTO licenta.sabloane(Nume_societate, Reg_Com, CIF, Adresa, IBAN, Banca, Cod_firma) VALUES ('" +
                            template.name + "', '" + template.regCom + "', '" + template.cif + "', '" +
                            template.address +
                            "', '" + template.iban + "', '" + template.bank +
                            "', (SELECT Cod_generat FROM licenta.usersdata WHERE Username = '" + this.currentUsername +
                            "'))";
                        using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datele au fost actualizate cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu se poate deschide conexiunea ! ", "Eroare SQL01",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
    }
}



