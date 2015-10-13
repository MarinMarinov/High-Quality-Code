using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4.Strategy
{
    public class EmailSender
    {
        private readonly ILogger logger;

        // Poor man's Dependency inversion
        public EmailSender()
            : this(new ConsoleLogger())
        {
        }

        public EmailSender(ILogger log) // Contstructor injection(DIP)
        {
            this.logger = log;
        }

        public void SendMail()
        {
            this.logger.Log("Connecting to the server...");
            this.logger.Log("Validating email address...");
            this.logger.Log("Sending mail...");
            this.logger.Log("Email sent!");
        }
    }
}
