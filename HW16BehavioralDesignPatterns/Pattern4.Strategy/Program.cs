using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4.Strategy
{
    class Program
    {
        static void Main()
        {
            ILogger fileLogger = new FileLogger("log.txt");

            EmailSender senderWithFileLogger = new EmailSender(fileLogger);
            senderWithFileLogger.SendMail(); // logs in the file

            EmailSender senderWithConsoleLogger = new EmailSender(); // the default contructor will construct parameter ConsoleLogger
            senderWithConsoleLogger.SendMail();
        }
    }
}
