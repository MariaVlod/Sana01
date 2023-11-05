using System;

class Program
{
    static void Main()
    {
        double m, n, x, a, b;

        Console.Write("Введіть число m: ");
        m = double.Parse(Console.ReadLine());

        Console.Write("Введіть число n: ");
        n = double.Parse(Console.ReadLine());

        Console.Write("Введіть число a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Введіть число b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Введіть число x: ");
        x = double.Parse(Console.ReadLine());


        double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        double z3 = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

        Console.WriteLine($"Результат виразу z1 = {z1}");
        Console.WriteLine($"Результат виразу z2 = {z2}");
        Console.WriteLine($"Результат виразу z3 = {z3}");
    }
}





