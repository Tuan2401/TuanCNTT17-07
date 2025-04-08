using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            // Nhập số từ bàn phím
            Console.Write("Nhập vào một số: ");
            double so = double.Parse(Console.ReadLine());

            // Kiểm tra số
            if (so > 0)
            {
                Console.WriteLine($"{so} là số dương.");
            }
            else if (so < 0)
            {
                Console.WriteLine($"{so} là số âm.");
            }
            else
            {
                Console.WriteLine("Số bạn nhập là số 0.");
            }

            Console.ReadKey(); // Giữ màn hình console
        }
    }
}
 
