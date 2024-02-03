using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_API.Helper
{
    public class EmailSender : IEmailSender
    {
        private readonly MailJetSettings _mailJetSettings;

        public EmailSender(IOptions<MailJetSettings> mailjetSettings)
        {
            _mailJetSettings = mailjetSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient(_mailJetSettings.PublicKey,
                _mailJetSettings.PrivateKey){
                // here you're supposed to set the version by hand, 'cause reasons, and you can't use the official documentation, because "Version" is undefined. Great job, MailJet -_-. 
            };
            //MailjetRequest request = new MailjetRequest
            //{
            //    Resource = Send.Resource,
            //}
            //   .Property(Send.Messages, new JArray {
            //    new JObject {
            //     {"From", new JObject {
            //      {"Email", _mailJetSettings.Email},
            //      {"Name", "Mailjet Pilot"}
            //      }},
            //     {"To", new JArray {
            //      new JObject {
            //       {"Email", email},
            //       {"Name", "Hello"}
            //       }
            //      }},
            //     {"Subject", subject},
            //     {"HTMLPart", htmlMessage}
            //     }
            //       });

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, _mailJetSettings.Email)
            .Property(Send.FromName, "PyRO")
            .Property(Send.Subject, subject)
            .Property(Send.HtmlPart, htmlMessage)
            .Property(Send.Recipients, new JArray {
                new JObject {
                 {"Email", email}
                 }
                });

            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
