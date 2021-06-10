using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DatabaseLogger : ILogger
    {
        public string WriteLog()
        {
            return "Veritabanına Loglandı.";
        }
    }
}
