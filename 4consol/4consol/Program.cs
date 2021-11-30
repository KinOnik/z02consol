using System;

namespace _4consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i > 2; i--)
            {
                for (int j = 0; j < 8 - i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
