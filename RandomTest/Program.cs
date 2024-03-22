using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r 1 = new Random ( 2 2 ) ;
            Random r 2 = new Random ( 2 2 ) ;
            for (int i = 0 ; i < 4 ; i ++)
                Console.WriteLine( r1.Next());
            Console.WriteLine();
            for (int i = 0 ; i < 4 ; i ++)
                Console.WriteLine ( r2.Next ());
        }
    }
}
