using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class DatabaseLoggerSevice : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database in Logged!");
        }
    }
}
