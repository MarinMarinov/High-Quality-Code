using System;
using System.Threading;

namespace Pattern3.TemplateMethod
{
    class MailBgSender : EmailSenderAbstraction
    {
        public MailBgSender(string sender, string reciever, string message)
            : base(sender, reciever, message)
        {
        }

        protected override bool CheckEmailAddress()
        {
            return this.EmailSender.EndsWith("@mail.bg");
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
