using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai9
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên dương n
            Console.Write("Nhập vào số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            long giaiThua = 1;

            if (n < 0)
            {
                Console.WriteLine("Không tính được giai thừa của số âm.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }

                Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
            }

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
