using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licenta
{
    public class Drivers
    {
        public string cnp;
        public string name;
        public string surname;
        public string birthDate;
        public string employDate;
        public string drivingCat;
        public string phone;
        public string wage;

        public void checkValues()
        {
            if (cnp == null || name == null || surname == null || birthDate == null || employDate == null ||
                drivingCat == null || phone == null || wage == null)
            {
                MessageBox.Show("Datele soferului sunt incorecte sau incomplete!", "Eroare D01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsWellFormattedDate(birthDate))
            {
                MessageBox.Show("Data nasterii nu este valida!", "Eroare D02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!IsWellFormattedDate(employDate))
            {
                MessageBox.Show("Data angajarii nu este valida!", "Eroare D02", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
