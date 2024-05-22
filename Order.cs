using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Licenta
{
    public class Order
    {
        public string nr;
        public string companyName;
        public string date;
        public string value;

        public void checkValues()
        {
            if (nr == null || companyName == null || date == null || value == null)
            {
                MessageBox.Show("Datele comenzii sunt incorecte sau incomplete!", "Eroare C01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsWellFormattedDate(date))
            {
                MessageBox.Show("Data comenzii nu este valida!", "Eroare C02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool IsWellFormattedDate(string input)
        {
            string[] formats = { "dd/MM/yyyy", "dd.MM.yyyy", "dd-MM-yyyy" };

            if (DateTime.TryParseExact(input, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
