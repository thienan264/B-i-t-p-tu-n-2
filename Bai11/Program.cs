using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ví dụ mảng đã sắp xếp sẵn
        int[] arr = { 1, 3, 5, 7, 9 };

        Console.WriteLine("Mang ban dau:");
        Console.WriteLine(string.Join(" ", arr));

        Console.Write("Nhap so nguyen can chen: ");
        int x = int.Parse(Console.ReadLine());

        // Tạo mảng mới có thêm 1 phần tử
        int[] newArr = new int[arr.Length + 1];
        int i = 0, j = 0;
        bool inserted = false;

        while (i < arr.Length)
        {
            if (!inserted && x < arr[i])
            {
                newArr[j++] = x;
                inserted = true;
            }
            else
            {
                newArr[j++] = arr[i++];
            }
        }

        // Nếu x lớn nhất thì chèn vào cuối
        if (!inserted)
        {
            newArr[j] = x;
        }

        Console.WriteLine("Mang sau khi chen:");
        Console.WriteLine(string.Join(" ", newArr));
    }
}

