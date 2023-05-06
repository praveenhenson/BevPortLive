using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using BevPort.Helpers;

namespace BevPort_Staging.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region Function to Send Email to the Users and Admin - HIMANSHU MISHRA
        public ActionResult SendEmail(string receiver, string subject, string message)
        {
            try
            {
                BaseURL BaseURL = new BaseURL();
                var BccMail = "info@bevport.com";
                //var BccMail = "himanshu717171@gmail.com";
                var senderEmail = new MailAddress(BaseURL.senderEmailAddress, BaseURL.senderEmailName);
                var receiverEmail = new MailAddress(receiver, "Receiver");
                var password = BaseURL.senderPassword;
                var sub = subject;
                var body = message;
                var smtp = new SmtpClient
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                MailMessage _mailmsg = new MailMessage();
                _mailmsg.IsBodyHtml = true;

                _mailmsg.From = new MailAddress(senderEmail.ToString());

                //Set To Email ID  
                _mailmsg.To.Add(receiverEmail.ToString());
                _mailmsg.Bcc.Add(BccMail.ToString());
                //Set Subject  
                _mailmsg.Subject = subject;

                //Set Body Text of Email   
                _mailmsg.Body = message;
                smtp.Send(_mailmsg);
                return View();

            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
        #endregion
    }
}
