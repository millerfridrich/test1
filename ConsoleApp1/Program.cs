using System;

class Program
{
    static void Main()
    {
        string name = "Nishon";
        int num1 = 7;
        int num2 = 5;

        Additional(num1, num2);
    }

    static int Additional(int a, int b)
    {
        Console.WriteLine("Сумма равна " + (a + b));
        return a + b;
    }
}