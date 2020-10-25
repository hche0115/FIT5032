using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032_Week08A.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "SG.39lmbWEWTG-3yET4Ne95Bw.Hld4B4nNHNiiSe9GT3N_FCVWwjNT4LFl9yARKTt0w10";

        public void Send(String toEmail, String subject, String contents, HttpPostedFileBase postedFileBase)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("630751226@qq.com", "NextGen Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            if (postedFileBase != null && postedFileBase.ContentLength > 0)
            { 
                StreamReader reader = new StreamReader(postedFileBase.InputStream);
                string s = reader.ReadToEnd();   
                msg.AddAttachment(postedFileBase.FileName, s);

            }

            var response = client.SendEmailAsync(msg);
        }

    }
}