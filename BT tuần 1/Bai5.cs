using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai5
    {
        static void Main(string[] args)
        {
            // Nhập số thứ nhất
            Console.Write("Nhập số thứ nhất: ");
            double so1 = double.Parse(Console.ReadLine());

            // Nhập số thứ hai
            Console.Write("Nhập số thứ hai: ");
            double so2 = double.Parse(Console.ReadLine());

            // Tính tổng
            double tong = so1 + so2;

            // Tính tích
            double tich = so1 * so2;

            // In kết quả
            Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
            Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
    }
}
