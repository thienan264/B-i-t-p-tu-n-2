﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap thang (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam: ");
        int year = int.Parse(Console.ReadLine());

        int days;

        switch (month)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                days = 31;
                break;
            case 4: case 6: case 9: case 11:
                days = 30;
                break;
            case 2:
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    days = 29;
                else
                    days = 28;
                break;
            default:
                Console.WriteLine("Thang khong hop le!");
                return;
        }

        Console.WriteLine($"Thang {month} nam {year} co {days} ngay.");
    }
}
