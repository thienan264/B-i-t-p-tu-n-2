using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen b: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("So lon hon la: " + a);
        }
        else if (b > a)
        {
            Console.WriteLine("So lon hon la: " + b);
        }
        else
        {
            Console.WriteLine("Hai so bang nhau.");
        }
    }
}
