using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (BalancedBrackets.IsBalancedBracket())
            {
                Console.Write("No");
            }
            else
            {
                Console.Write("Yes");
            }
        }
    }
}
