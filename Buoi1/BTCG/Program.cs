using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCG
{
    class SinhVien
    {
        public string hoTen;
        public int MaSV, MaLop;

        public void Nhap()
        {
            Console.Write("Nhap Ho Ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap Ma SV: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ma Lop: ");
            MaLop = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Ho ten: {0}\nMa SV: {1}\nMa lop: {2}", hoTen, MaSV, MaLop);
        }
    }
    class QLSV
    {
        private SinhVien[] ds;
        private int ssv;
        public void Nhap()
        {
            Console.Write("Nhap so sinh vien: ");
            ssv = int.Parse(Console.ReadLine());
            ds = new SinhVien[ssv];
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine("Nhap thong tin cho sinh vien {0}: ", i + 1);
                ds[i] = new SinhVien();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            for (int i = 0; i < ds.Length; ++i)
            {
                ds[i].Hien();
            }
        }
        public void demSV()
        {
            int x;
            int count = 0;
            Console.Write("Nhap Ma lop: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].MaLop == x)
                {
                    count++;
                }
            }
            Console.WriteLine("So sinh vien lop {0} la {1}", x, count);
        }
    }
    class Program
    {
        static void Main()
        {
            QLSV sv = new QLSV();
            sv.Nhap();
            Console.WriteLine("Thong tin cac sinh vien:");
            sv.Hien();
            Console.WriteLine("Dem sinh vien cua mot lop:");
            sv.demSV();
            Console.ReadLine();
        }
    }
}