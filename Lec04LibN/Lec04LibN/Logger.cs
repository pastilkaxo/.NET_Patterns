using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lec04LibN
{
    public partial class Logger : ILogger
    {
        private string LogFileName = string.Format(@"{0}/LOG{1}.txt", Directory.GetCurrentDirectory(),DateTime.Now.ToString("yyyyMMdd-HH-mm-ss"));

        public DateTime now = DateTime.Now;
        public string CreateMsg = "INIT ";
        public string StartMsg =  "STRT ";
        public string StopMsg = "STOP ";
        public string LogMsg = "INFO ";
        public static int msgCount = 0;
        public static string titles;
        public static bool initiated = false;
        public void log(string message)
        {
            msgCount++;
            if (message.Contains(StartMsg))
            {
                File.AppendAllText(LogFileName, msgCount.ToString().PadLeft(6, '0') + "-" + now + "-" + message + titles + "\n");
            }
            else if (message.Contains(StopMsg))
            {
                File.AppendAllText(LogFileName, msgCount.ToString().PadLeft(6, '0') + "-" + now + "-" + message + titles + "\n");
            }
            else if (!initiated)
            {
                File.AppendAllText(LogFileName, msgCount.ToString().PadLeft(6, '0') + "-" + now + "-" + CreateMsg + "\n");
                initiated = true;
            }
            else
            {
                File.AppendAllText(LogFileName, msgCount.ToString().PadLeft(6, '0') + "-" + now + "-" + LogMsg + titles + message + "\n");
            }

        }
        public static ILogger create()
        {
            return new Logger();
        }

        public void start(string title)
        {
            titles += title + ":";
            log(StartMsg);
             
        }

        public void stop()
        {
            titles = titles.Remove(titles.Length - 2, 2);
            log(StopMsg);
        }
 



    }
}
