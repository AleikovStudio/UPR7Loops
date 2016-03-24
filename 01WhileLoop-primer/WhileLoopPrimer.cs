using System;

class WhileLoopPrimer
{
    static void Main()
    {
        Console.Write("Write n = ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        decimal sum = 1;

        Console.Write("The sum 1");
        while (i < n)
        {
            i++;
            sum += i; // към сумата се прибавя number-a!!!
            Console.Write("+{0}", i);
        }
        Console.WriteLine(" = {0}", sum);
    }
}
