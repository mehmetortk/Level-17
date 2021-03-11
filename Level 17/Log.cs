using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_17
{
    interface ILog
    {
        void Log();
    }

    class Database:ILog
    {
      public  void Log()
      {
          Console.WriteLine("Logged to Database!!");
      }

    }

    class Message : ILog
    {
        public void Log()
        {
            Console.WriteLine("Logged to Message!!");

        }
    }

    class System : ILog
    {
        public void Log()
        {
            Console.WriteLine("Logged to System!!");

        }
    }
}
