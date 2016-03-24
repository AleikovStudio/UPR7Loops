using System;

class FindFactorialDoWhileLoop
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;

        do
        {
            factorial *= n;
            n--;
        } while (n > 0);
        Console.WriteLine("n! = {0}", factorial);
    }
}
