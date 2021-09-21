using System;

namespace FibForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            int counter = 10;
            for(int i = 1;i <= counter; i++)
            {
                int num3 = num1;
                num1 = num2;
                num2 = num3 + num2;
                Console.WriteLine(num1);

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
