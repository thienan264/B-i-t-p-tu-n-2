using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chieu dai a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong b: ");
        int b = int.Parse(Console.ReadLine());

        int P = (a + b) * 2;
        int S = a * b;

        Console.WriteLine("Chu vi hinh chu nhat: " + P);
        Console.WriteLine("Dien tich hinh chu nhat: " + S);
    }
}

