using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Licenta
{
    public class Mail
    {
        public void sendMail(string to, string subject, string body)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("noreply@licenta.com");
                message.To.Add(new MailAddress(to));
                message.Subject = subject;
                message.Body = body;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ciobanudanut01@gmail.com", "gyns seet nmei cecu ");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Eroare la trimiterea emailului ! ", "Eroare MAIL01",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
