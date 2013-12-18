using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton() {}

        /*Create the one instance here*/                 /*Eager initialization*/
        private static /*readonly*/ Singleton instance = new Singleton();

        /*Lazy initialization 4byte reference*/
        //private static Singleton instance;
        //public static Singleton getSingletonLazy()
        //{
        //    if (instance == null)
        //        instance = new Singleton();
        //    return instance;
        //}

        /*Provide access to the one instance with a GET method*/
        public static Singleton getSingleton() { return instance; }

        private StreamWriter outStream;
        private int logNumber = 0;
        public void InitializeLogging()
        {
            outStream = new StreamWriter("myLog.txt");
        }
        public void ShutdownLogging()
        {
            outStream.Close();
        }
        public void LogMessage(string message)
        {
            outStream.WriteLine((logNumber++) + ": " + message);
        }
    }

    //static class Logger
    //{
    //    static StreamWriter outStream;
    //    static int logNumber = 0;
    //    static public void InitializeLogging()
    //    {
    //        outStream = new StreamWriter("myLog.txt");
    //    }
    //    static public void ShutdownLogging()
    //    {
    //        outStream.Close();
    //    }
    //    static public void LogMessage(string message)
    //    {
    //        outStream.WriteLine((logNumber++) + ": " + message);
    //    }
    //}
}
