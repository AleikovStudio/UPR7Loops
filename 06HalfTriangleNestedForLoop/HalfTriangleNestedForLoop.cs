using System;

class HalfTriangleNestedForLoop
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
            Console.Write("{0}", n-row);
            for (int column = 1; column <= row; column++)
            {
                Console.Write("{0} ", column);
            }
            Console.WriteLine();
        }
    }
}
