using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen c: ");
        int c = int.Parse(Console.ReadLine());

        int max;

        if (a >= b && a >= c)
            max = a;
        else if (b >= a && b >= c)
            max = b;
        else
            max = c;

        Console.WriteLine("So lon nhat la: " + max);
    }
}
