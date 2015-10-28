using System;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Hello, dear user. This is the simplest AF Calculator.");
            Console.WriteLine("\nPlease enter the first integer:");
            string value1 = Console.ReadLine();
            int a = int.Parse(GetValue(value1));
            Console.WriteLine("\nPlease enter the second integer:");
            string value2 = Console.ReadLine();
            int b = int.Parse(GetValue(value2));
            Console.WriteLine("\nPlease enter the action: \n1 for +, \n2 for -, \n3 for * or \n4 for / ");
            string action = Console.ReadLine();
            int c = int.Parse(GetValue(action));
            switch (c)
            {
                case 1:
                    var res1 = Sum(a, b);
                    Console.WriteLine("\nThe result of sum is: " + res1);
                    break;
                case 2:
                    var res2 = Substract(a, b);
                    Console.WriteLine("\nThe result of substract is: " + res2);
                    break;
                case 3:
                    var res3 = Multiply(a, b);
                    Console.WriteLine("\nThe result of multiply is: " + res3);
                    break;
                case 4:
                    if (b != 0)
                    {
                        var res4 = Devide(a, b);
                        Console.WriteLine("\nThe result of devide is: " + res4);
                    }
                    else
                    {
                        Console.WriteLine("\nError. Can't devide on 0");
                    }
                    break;
                default: Console.WriteLine("It's not a valid action!"); break;
            }
            Console.WriteLine("\nPress enter to close...");
            Console.ReadLine();
        }

        public static string GetValue(string value)
        {
            int tempValue;
            while (!Int32.TryParse(value, out tempValue))
            {
                Console.WriteLine("Not a valid number, try again.");
                value = Console.ReadLine();
            }
            return value;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Devide(int a, int b)
        {
            return a / b;
        }
    }
}
