using System;

class Program
{
    static void Main()
    {
        string name = "Nishon";
        int num1 = 7;
        int num2 = 5;

        Additional(num1, num2);
        Multiply(num1, num2);
    }

    static int Additional(int a, int b)
    {
        Console.WriteLine("Сумма равна " + (a + b) + "\n");
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        Console.WriteLine("Произведение равно " + (a * b) + "\n");
        return a * b;
    }
}