using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static double deQuy(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }

            return a * deQuy(a, b - 1);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập x: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.Write("Nhập x: ");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine($"Kết quả: {deQuy(x, y)}");

            Console.ReadKey();
        }
    }
}
