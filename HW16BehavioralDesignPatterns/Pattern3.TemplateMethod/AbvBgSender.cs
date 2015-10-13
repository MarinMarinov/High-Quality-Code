using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pattern3.TemplateMethod
{
    public class AbvBgSender : EmailSenderAbstraction
    {
        public AbvBgSender(string sender, string reciever, string message)
            : base(sender, reciever, message)
        {

        }

        protected override bool CheckEmailAddress()
        {
            return this.EmailSender.EndsWith("@abv.bg");
        }

        protected override bool ValidateMessage()
        {
            return this.Message.Contains("spam");
        }

        protected override bool Connect()
        {
            Console.WriteLine("Connecting to abv.bg on port 465 (secure SMTP connection)...");
            Thread.Sleep(1000);
            Console.WriteLine("Check email address...");
            Thread.Sleep(1000);
            Console.WriteLine("Sending email...");

            return true;
        }
    }
}