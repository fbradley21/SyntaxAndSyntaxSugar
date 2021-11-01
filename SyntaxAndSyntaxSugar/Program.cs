using System;

namespace SyntaxAndSyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;



            if (answer < 9)
            {
                Console.WriteLine($"{answer} is less than 9");
            }
            else
            {
                Console.WriteLine($"{answer} is correct!");
            }

        }
    }
}
