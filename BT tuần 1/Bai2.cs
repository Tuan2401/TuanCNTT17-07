using System;

namespace lab1._1
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            // Nhập chiều dài
            Console.Write("Nhập chiều dài: ");
            double chieuDai = double.Parse(Console.ReadLine());

            // Nhập chiều rộng
            Console.Write("Nhập chiều rộng: ");
            double chieuRong = double.Parse(Console.ReadLine());

            // Tính diện tích
            double dienTich = chieuDai * chieuRong;

            // In kết quả
            Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");

            Console.ReadKey();
        }
    }
}
