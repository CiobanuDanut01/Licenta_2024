using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licenta
{
    public class Truck
    {
        public string plate;
        public string brand;
        public string model;
        public string year;
        public string vigDate;
        public string itpDate;
        public string rcaDate;
        public string driverName;
        public bool isDataCorrect;

        public void checkValues()
        {
            isDataCorrect = true;
            if (plate == null || brand == null || model == null || year == null || vigDate == null ||
                itpDate == null || rcaDate == null || driverName == null)
            {
                MessageBox.Show("Datele camionului sunt incorecte sau incomplete!", "Eroare T01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isDataCorrect = false;
                return;
            }

            if (!IsWellFormattedDate(vigDate))
            {
                MessageBox.Show("Data valabilitatii vignetei nu este valida!", "Eroare T02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isDataCorrect = false;
                return;
            }

            if (!IsWellFormattedDate(itpDate))
            {
                MessageBox.Show("Data valabilitatii ITP-ului nu este valida!", "Eroare T02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isDataCorrect = false;
                return;
            }

            if (!IsWellFormattedDate(rcaDate))
            {
                MessageBox.Show("Data valabilitatii RCA-ului nu este valida!", "Eroare T02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isDataCorrect = false;
                return;
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
