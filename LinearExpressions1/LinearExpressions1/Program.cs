using System;

class Program
{
    static void Main()
    {

        double a, b, c, d;

        Console.Write("Введіть число a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Введіть число b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Введіть число c: ");
        c = double.Parse(Console.ReadLine());

        Console.Write("Введіть число d: ");
        d = double.Parse(Console.ReadLine());


        double x = (a + 2 * b - c + d) / (c * d) + (a + b) * (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
        double y = 5 * (a + b) * (c - d) / ((1.0 / 2 * c)) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        double z = ((Math.Pow(x, 2) - 2 * Math.Pow(x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
        double r = ((1.0/2 * a + 3.0/4 * b - 7.0/5.0) / (3 * c + 1)) + (1 / (a - c));


        Console.WriteLine($"Результат виразу x = {x}");
        Console.WriteLine($"Результат виразу y = {y}");
        Console.WriteLine($"Результат виразу z = {z}");
        Console.WriteLine($"Результат виразу r = {r}");

    }
}
