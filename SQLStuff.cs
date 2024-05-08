using System;
using System.Collections.Generic;
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
                        }
                        else
                        {
                            MessageBox.Show("Logare esuata!\nDatele nu corespund celor din tabel, incercati sa va inregistrati!", "Eroare SQL03", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.isLoginSucces = true;

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
    }
}
