using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProg();
        }

        private static void StartProg()
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a number: ");
                Int32.TryParse(Console.ReadLine(), out int input);

                if (input == ReverseNumber(input))
                {
                    Console.WriteLine("Is a Palindrome");
                }
                else
                {
                    Console.WriteLine("Is not a Palindrome");
                }
            }
        }

        private static int ReverseNumber(int input)
        {
            var reverse = string.Join("", Math.Abs(input).ToString().Reverse());
            return int.Parse(reverse) * Math.Sign(input);
        }
    }
}
