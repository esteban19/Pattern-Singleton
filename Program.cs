using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("me line");
            //restrict Singleton to one instance, can't do it here!
            //Singleton logger = new Singleton();

            //Singleton class name.getSingleton().members/methods();
            Singleton.getSingleton().InitializeLogging();
            Singleton.getSingleton().LogMessage("I love static data");
            Singleton.getSingleton().LogMessage("static data exists before and after main()");
            Singleton.getSingleton().LogMessage("When I think static, I think memory created by the compiler");
            Singleton.getSingleton().ShutdownLogging();

            //Logger.InitializeLogging();
            //Logger.LogMessage("I love static data");
            //Logger.LogMessage("static data exists before and after main()");
            //Logger.LogMessage("When I think static, I think memory created by the compiler");
            //Logger.ShutdownLogging();
        }
    }
}
