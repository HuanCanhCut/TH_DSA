using System;
using System.Text;

class Program
{
    static int TimUocSoLeLonNhat(int n, int uoc = 1)
    {
        // Trường hợp cơ sở: nếu n là số lẻ, nó chính là ước số lẻ lớn nhất
        if (n % 2 != 0)
        {
            return n;
        }

        // Nếu n chẵn, chia n cho 2 và gọi đệ quy
        return TimUocSoLeLonNhat(n / 2, uoc);
    }

    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int ketQua = TimUocSoLeLonNhat(n);
            Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
        }

        Console.ReadKey();
    }
}