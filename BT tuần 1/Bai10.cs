using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai10
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên n
            Console.Write("Nhập vào số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            bool laSoNguyenTo = true;

            if (n < 2)
            {
                laSoNguyenTo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
