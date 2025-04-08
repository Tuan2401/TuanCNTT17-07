using System;

namespace lab1._1
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            // Nhập tên
            Console.Write("Nhập tên của bạn: ");
            string ten = Console.ReadLine();

            // Nhập tuổi
            Console.Write("Nhập tuổi của bạn: ");
            int tuoi = int.Parse(Console.ReadLine());

            // In ra kết quả
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}

