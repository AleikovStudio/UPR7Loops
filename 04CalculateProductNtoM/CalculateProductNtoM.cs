using System;

class CalculateProductNtoM
{
    static void Main()
    {
        Console.WriteLine("Enter your 1st number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 2nd number: ");
        int m = int.Parse(Console.ReadLine());
        int number = n;
        decimal product = 1;
        do
        {
            product *= number;
            number++;
        } while (m > number);
        Console.WriteLine("The result from n to m is: {0}", product);
    }
}
