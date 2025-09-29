using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Tong cac phan tu trong mang = " + sum);
    }
}

