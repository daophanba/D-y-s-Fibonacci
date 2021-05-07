using System;

namespace VietTutsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            Console.Write("100 so dau tien cua day so Fibonacci: \n");
            for (i = 0; i < 100; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }

            Console.WriteLine();
            Console.ReadKey();
        }


        
        static int fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
