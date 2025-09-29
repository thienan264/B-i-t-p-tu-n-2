using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "input_array.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Khong tim thay file input_array.txt");
            return;
        }

        // Đọc file và chuyển thành mảng int
        string content = File.ReadAllText(filePath);
        int[] arr = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

        Console.WriteLine("Mang ban dau:");
        Console.WriteLine(string.Join(" ", arr));

        // Selection Sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Hoán đổi
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        Console.WriteLine("Mang sau khi sap xep tang dan:");
        Console.WriteLine(string.Join(" ", arr));
    }
}
