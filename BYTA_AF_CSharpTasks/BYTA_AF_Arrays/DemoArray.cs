using System;

namespace DemoArray
{
    class DemoArray
    {
        static void Main()
        {
            Console.WriteLine("Please enter parameters of Array :");
            int n = int.Parse(Console.ReadLine());
            int [,] AfIntArray = new int[n,n];
            Random rnd = new Random();
            int x;
            Console.WriteLine("\nInput random values to {0} x {0} Array... ", n);
            Console.WriteLine("\nPlease verify generated {0} x {0} Array: ", n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x = rnd.Next(100);
                    AfIntArray[i, j] = x;
                    Console.Write("{0} ", AfIntArray[i, j]);
                }
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
            
        }
    }
}
