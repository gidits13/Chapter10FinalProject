using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10FinalProject
{
    public class Logger : Ilogger
    {
        public Logger(string path)
        { this.path = path; }
        public string path;
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void WriteToFile(string message)
        {
            try 
            { 
                FileInfo fileInfo = new FileInfo(path);
                using (StreamWriter sw = fileInfo.AppendText())
                {
                    sw.WriteLine(message+" " +DateTime.Now);
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            
        }
    }
}
