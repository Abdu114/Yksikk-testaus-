using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            String luku;
            Console.WriteLine("Anna luku?");
            luku = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(luku);
            int i = Int32.Parse(luku);
            for (i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
