using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HomeRepo
    {
        static EbookEntities db;

        static HomeRepo()
        {
            db = new EbookEntities();
        }


        public static ProductBook BookDetails(int id)
        {
            return db.ProductBooks.FirstOrDefault(pb => pb.Id == id);
        }

        public static void Contact(Contact model)
        {
            using (MailMessage mail = new MailMessage("samiulsiam59@gmail.com", model.Too))
            {
                mail.Subject = model.Subject;
                mail.Body = model.Body;
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;

                    NetworkCredential nc = new NetworkCredential("samiulsiam59@gmail.com", "Siam38844-3");
                    smtp.UseDefaultCredentials = true;

                    smtp.Credentials = nc;
                    smtp.Port = 587;

                    smtp.Send(mail);
                }
            }
        }
    }
}
