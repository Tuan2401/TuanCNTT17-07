using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai8
    {
        static void Main(string[] args)
        {
            // In bảng cửu chương từ 1 đến 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Bảng cửu chương {i}:");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine(); // Xuống dòng giữa các bảng
            }

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
