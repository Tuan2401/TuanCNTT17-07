using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            // Nhập năm từ bàn phím
            Console.Write("Nhập vào một năm: ");
            int nam = int.Parse(Console.ReadLine());

            // Kiểm tra năm nhuận
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine($"{nam} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{nam} không phải là năm nhuận.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
