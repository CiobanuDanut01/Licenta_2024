using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licenta
{
    public class Invoice
    {
        public string nr;
        public string companyName;
        public string date;
        public string value;
        public string valueTVA;
        public string valueTotal;
        public string currency;

        public void checkValues()
        {
            if (nr == null || companyName == null || date == null || value == null || valueTVA == null ||
                valueTotal == null || currency == null)
            {
                MessageBox.Show("Datele facturii sunt incorecte sau incomplete!", "Eroare F01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
