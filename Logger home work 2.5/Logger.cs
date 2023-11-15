using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_home_work_2._5
{
    public class Logger
    {
        public void LogInfo(string message)
        {
            Log("Info", message);
        }

        public void LogWarning(string message)
        {
            Log("Warning", message);
        }

        public void LogError(string message)
        {
            Log("Error", message);
        }

        private void Log(string logType, string message)
        {
            string logTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt");
            Console.WriteLine($"{logTime}: {logType}: {message}");
        }
    }
}
