using System;
using System.Text.RegularExpressions;

namespace Exercise_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            var find = Console.ReadLine();
            var findReg = new Regex(find);
            Console.WriteLine("Word found " + findReg.Matches(str).Count.ToString() + " times in the string");

        }
    }
}