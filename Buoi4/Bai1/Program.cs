using System;
using System.Text;


namespace Program
{
    class TinhThanh
    {
        public string tenTinh { get; set; }
        public double dienTich { get; set; }
        public int danSo { get; set; }

        public void nhap()
        {
            Console.Write("Nhập tên tỉnh: ");
            tenTinh = Console.ReadLine();

            Console.Write("Nhập diện tích: ");
            dienTich = double.Parse(Console.ReadLine());

            Console.Write("Nhập dân số: ");
            danSo = int.Parse(Console.ReadLine());
        }
    }

    class Node
    {
        public TinhThanh Data;
        public Node Next;

        public Node(TinhThanh data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Node addNode(TinhThanh data, Node current)
        {
            Node newNode = new Node(data);
            current.Next = newNode;
            return newNode;
        }

        public Node update(string tenTinh, Node linkedList)
        {
            Node current = linkedList;
            while (current != null)
            {
                if (current.Data.tenTinh == tenTinh)
                {
                    TinhThanh tinh = new TinhThanh();
                    tinh.nhap();
                    current.Data = tinh;
                }
                current = current.Next;
            }

            return linkedList;
        }

        public Node delete(Node linkedList)
        {
            Node current = linkedList;

            Console.Write("Nhập tên tỉnh cần xóa: ");
            string tenTinhXoa = Console.ReadLine();

            int index = 0;
            while (current != null)
            {
                if (current.Data.tenTinh == tenTinhXoa)
                {
                    break;
                }
                index++;
                current = current.Next;
            }

            if (index == 0)
            {
                return linkedList.Next;
            }

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

            return linkedList;
        }

        public void tinhTongDienTich(Node linkedList, out double tongDienTich)
        {
            Node current = linkedList;
            tongDienTich = 0;

            while (current != null)
            {
                tongDienTich += current.Data.dienTich;
                current = current.Next;
            }
        }

        public void HienThi(Node linkedList)
        {
            Node current = linkedList;

            Console.WriteLine($"{"Tên tỉnh",-20} {"Diện tích",-20} {"Dân số",-20}");
            while (current != null)
            {
                Console.WriteLine($"{current.Data.tenTinh,-20} {current.Data.dienTich,-20} {current.Data.danSo,-20}");
                current = current.Next;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số phần tử của danh sách: ");
            int n = int.Parse(Console.ReadLine());

            TinhThanh tinh = new TinhThanh();
            tinh.nhap();

            Node linkedList = new Node(tinh);

            Node current = linkedList;

            for (int i = 1; i < n; i++)
            {
                tinh = new TinhThanh();
                tinh.nhap();
                current = current.addNode(tinh, current);
            }


            double tongDienTich;
            linkedList.tinhTongDienTich(linkedList, out tongDienTich);
            Console.WriteLine($"Tổng diện tích: {tongDienTich}");


            Console.Write("Nhập tên tỉnh cần cập nhật: ");
            string tenTinh = Console.ReadLine();
            linkedList = linkedList.update(tenTinh, linkedList);

            linkedList.HienThi(linkedList);

            linkedList = linkedList.delete(linkedList);

            linkedList.HienThi(linkedList);

            Console.Write("Nhập S1: ");
            double S1 = double.Parse(Console.ReadLine());

            Console.Write("Nhập S2: ");
            double S2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{"Tên tỉnh",-20} {"Diện tích",-20} {"Dân số",-20}");
            current = linkedList;
            while (current != null)
            {
                if (current.Data.dienTich >= S1 && current.Data.dienTich <= S2)
                {
                    Console.WriteLine($"{current.Data.tenTinh,-20} {current.Data.dienTich,-20} {current.Data.danSo,-20}");
                }
                current = current.Next;
            }

            Console.Write("Nhập X m2: ");
            double X = double.Parse(Console.ReadLine());

            Console.WriteLine($"{"Tên tỉnh",-20} {"Diện tích",-20} {"Dân số",-20}");
            current = linkedList;
            while (current != null)
            {
                if (current.Data.dienTich >= X)
                {
                    Console.WriteLine($"{current.Data.tenTinh,-20} {current.Data.dienTich,-20} {current.Data.danSo,-20}");
                }
                current = current.Next;
            }

            Console.ReadKey();
        }
    }
}