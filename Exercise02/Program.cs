using System;
using Exercise01;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert to words: ");
            ulong n = ulong.Parse(Console.ReadLine());

            Console.WriteLine("{0}", Exercise01.Exercise01.TowardsWrapper(n)) ;
        }
    }
}
