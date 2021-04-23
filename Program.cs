using System;

namespace สามเหลี่ยมปาสคาล
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            check(out n);
            Pascal(n);
        }
        static void check(out int n)
        {
            do 
            { 
                n = int.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
            while (n < 0);
        }
        static void Pascal(int n) 
        {
            int i,j,a;
            for (i = 0; i <= n; i++) 
            {
                for(j=0; j<=i; j++)
                { 
                    a = Combination(i, j);
                    Console.Write(a);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static int Combination(int n, int r)
        {
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }




    }
}
