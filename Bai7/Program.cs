using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap do dai canh a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap do dai canh b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap do dai canh c: ");
        double c = double.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0 &&
            a + b > c && a + c > b && b + c > a)
        {
            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Chu vi tam giac: {P}");
            Console.WriteLine($"Dien tich tam giac: {S}");
        }
        else
        {
            Console.WriteLine("Ba doan thang khong lap thanh mot tam giac hop le.");
        }
    }
}
