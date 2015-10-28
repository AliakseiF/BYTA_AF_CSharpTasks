using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingByVowels
{
    internal class SortingByVowels
    {
        private static void Main()
        {
            Console.WriteLine("Please enter number of lines :");
            //old two demention array try.
            //string [,] AfTextArray = new string[n,2];
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Please enter your line "+i+" text:");
            //    string text = Console.ReadLine().ToLower();
            //    string count = countVowels(text).ToString();
            //    AfTextArray[i-1,0] = text;
            //    AfTextArray[i-1,1] = count;
            //}
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> LineVowelsCount = new Dictionary<string, int>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nPlease enter your line {0} text: ", i);
                string text = Console.ReadLine().ToLower();
                int count = countVowels(text);
                LineVowelsCount.Add(text,count);
            }
            Console.WriteLine("\nYour entered lines are sorted by vowels count asc : ");
            var result = LineVowelsCount.OrderBy(k => k.Value).ToList();
            foreach (var entry in result)
            {
                Console.WriteLine("count:{0}, line: {1}", entry.Value, entry.Key);
            }
            Console.WriteLine("\nPress enter to close...");
            Console.ReadLine();

        }

        public static int countVowels(string text)
        {
            int countOfVowels = text.Count(c => "aeiou".Contains(c));
            Console.WriteLine("\nYour total number of vowels is: {0}", countOfVowels);
            return countOfVowels;
        }
    }
}
