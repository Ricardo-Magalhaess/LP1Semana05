using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();
            
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = crono1.Elapsed;
            // Get the elapsed time as a TimeSpan value.
            TimeSpan crono2ts = crono2.Elapsed ;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            // Format and display the TimeSpan value.
            string 2elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                2ts.Hours, 2ts.Minutes, 2ts.Seconds,
                2ts.Milliseconds / 10);
            
            
            Console.WriteLine("RunTime crono1: " + elapsedTime);
            
            Console.WriteLine("RunTime crono2: " + 2elapsedTime);
        }
    }
}
