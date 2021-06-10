using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager lm = new LogManager(new DatabaseLogger());
            lm.WriteLog();

            lm = new LogManager(new FileLogger());
            lm.WriteLog();

            lm = new LogManager(new SmsLogger());
            lm.WriteLog();
        }
    }
}
