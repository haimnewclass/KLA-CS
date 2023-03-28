using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4
{
    internal class LogInterface
    {
        public void Run()
        {
            ILog log= null;
            int logType = int.Parse(Console.ReadLine());
            if(logType == 0 )
            {
                log = new ConsoleLog();
            }else
            {
                log = new FileLog();
            }

            Recipe recipe = new Recipe(log);
            recipe.Run();
        }
    }

    public class FileLog :ILog
    {
        public void WriteToLog(string message, DateTime dateTime)
        {
            System.IO.File.WriteAllText("log.txt", message + " " + dateTime.ToString());
        }

        public void Blabla()
        {

        }
    }

    public class ConsoleLog : ILog
    {
        public void WriteToLog(string message, DateTime dateTime)
        {
            Console.WriteLine("log.txt", message + " " + dateTime.ToString());
        }
    }


    public interface ILog
    {
        void WriteToLog(string message, DateTime dateTime);
    }

    public class Recipe
    {
        public Recipe(ILog aLog)
        {
            log = aLog;
        }
        public ILog log;
        public void Run()
        {
          
            /////
            //////
            ///////
            ///bug
            log.WriteToLog("Found bug, archer outof memory",DateTime.Now);


            ///////
            ///bug
            log.WriteToLog("Found bug, archer outof disk", DateTime.Now);


        }

    }


}
