using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            // Nhập nhiệt độ Celsius
            Console.Write("Nhập nhiệt độ (độ C): ");
            double doC = double.Parse(Console.ReadLine());

            // Công thức chuyển sang độ F
            double doF = doC * 9 / 5 + 32;

            // In kết quả
            Console.WriteLine($"{doC} độ C = {doF} độ F");

            Console.ReadKey();
        }
    }
}