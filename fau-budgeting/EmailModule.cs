using Nancy;
using Nancy.ModelBinding;

using System.Net;
using System.Net.Mail;

namespace fau_budgeting
{
    class PostData
    {
        public string Email;
        public string Password;
        public string Subject;
        public string Body;
    }

    public class EmailModule : NancyModule
    {
        public EmailModule()
        {
            Get["/email"] = _ => View["email"];

            Post["/send-email"] = _ =>
            {
                PostData data = this.Bind<PostData>();

                var fromAddress = new MailAddress(data.Email);
                var password = data.Password;

                var toAddress = fromAddress;

                MailMessage message = new MailMessage
                {
                    Subject = data.Subject,
                    From = fromAddress,
                    Body = data.Body
                };

                message.To.Add(toAddress);

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, password)
                };

                string response;

                try
                {
                    smtp.Send(message);
                    response = "Message sent.";
                }
                catch (SmtpException)
                {
                    response = "There was an error connecting to the email server. Your credentials may be incorrect.";
                } finally
                {
                    smtp.Dispose();
                }

                return response;
            };
        }
    }
}