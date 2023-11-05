using System;

class Program
{
    static void Main()
    {
        double m, n;

        Console.Write("Введіть число m: ");
        m = double.Parse(Console.ReadLine());

        Console.Write("Введіть число n: ");
        n = double.Parse(Console.ReadLine());

        double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;


        Console.WriteLine($"Результат виразу z1 = {z1}");
        Console.WriteLine($"Результат виразу z2 = {z2}");
    }
}





