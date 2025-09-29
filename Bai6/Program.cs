using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chieu dai (so thuc duong): ");
        double dai = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap chieu rong (so thuc duong): ");
        double rong = Convert.ToDouble(Console.ReadLine());

        if (dai <= 0 || rong <= 0)
        {
            Console.WriteLine("Chieu dai va chieu rong phai la so thuc duong!");
            return;
        }

        double chuVi = 2 * (dai + rong);
        double dienTich = dai * rong;

        Console.WriteLine($"Chu vi hinh chu nhat: {chuVi}");
        Console.WriteLine($"Dien tich hinh chu nhat: {dienTich}");
    }
}
