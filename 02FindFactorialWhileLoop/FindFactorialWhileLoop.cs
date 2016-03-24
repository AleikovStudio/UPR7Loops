using System;
using System.Numerics;

class FindFactorialWhileLoop
{
    static void Main()
    {
        {
            Console.Write("Enter your factorial number = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            while (true)
            {
                Console.Write(n);
                if (n == 1)
                {
                    break;
                }
                Console.Write(" * ");
                factorial *= n;
                n--;
            }
            Console.WriteLine(" = {0}", factorial);
        }
    }
}