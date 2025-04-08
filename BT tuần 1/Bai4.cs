using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
    {
        internal class Bai4
        {
            static void Main(string[] args)
            {
                // Nhập số nguyên từ bàn phím
                Console.Write("Nhập vào một số nguyên: ");
                int n = int.Parse(Console.ReadLine());

                // Kiểm tra chẵn hay lẻ
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n} là số chẵn.");
                }
                else
                {
                    Console.WriteLine($"{n} là số lẻ.");
                }

                Console.ReadKey(); // Giữ màn hình console
            }
        }
    }
