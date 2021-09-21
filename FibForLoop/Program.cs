using System;

namespace FibForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 0;
            long num2 = 1;
            long sum = 0;
            for(long i = 1;i <= 10; i++)
            {
                long num3 = num1;
                num1 = num2;
                num2 = num3 + num2;
                Console.WriteLine(num1 + " ");

                if(num1 % 2 == 0)
                {
                    sum = sum + num1;
                }
            }

            Console.WriteLine("====");
            Console.WriteLine("Sum of even numbers: "+sum);
        }
    }
}
