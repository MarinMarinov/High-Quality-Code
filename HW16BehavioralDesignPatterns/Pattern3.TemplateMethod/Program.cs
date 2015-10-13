using System;

namespace Pattern3.TemplateMethod
{
    class Program
    {
        static void Main()
        {
            EmailSenderAbstraction abvBg = new AbvBgSender("ivan@abv.bg", "petkan@gmail.com", "Very important message!");
            bool abvBgSenderResult = abvBg.SendMail();
            Console.WriteLine("Result: {0}", abvBgSenderResult ? "Email successfully sent!" : "Failed to send email!");

            EmailSenderAbstraction mailBg = new MailBgSender("spammer@mail.bg", "petkan@gmail.com", "This is spam");
            bool mailBgSender = mailBg.SendMail();
            Console.WriteLine("Result: {0}", mailBgSender ? "Email successfully sent!" : "Failed to send email!");
        }
    }
}
