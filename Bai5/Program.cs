using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // a) Kiểm tra chẵn hay lẻ
        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} la so chan.");
        }
        else
        {
            Console.WriteLine($"{n} la so le.");
        }

        // b) Kiểm tra âm hay không âm
        if (n < 0)
        {
            Console.WriteLine($"{n} la so am.");
        }
        else
        {
            Console.WriteLine($"{n} la so khong am.");
        }
    }
}
