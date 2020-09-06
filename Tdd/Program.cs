using System;

namespace Tdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int boundary = 100;
            for (int i = 1; i < boundary; i++)
            {
                Console.WriteLine(FizzBuzzHandler.Handle(i));
            }
        }
    }
}
