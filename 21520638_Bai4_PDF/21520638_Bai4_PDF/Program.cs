using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21520638_Bai4_PDF
{
    class PhanSo
    {
        public int tu { get; set; }
        public int mau { get; set; }
        public PhanSo()
        {
            tu = 0;
            mau = 0;
        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau: ");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("{0}/{1}", tu, mau);
        }
        public static PhanSo operator+ (PhanSo a, PhanSo b)
        {
            PhanSo Tong = new PhanSo();
            Tong.tu = a.tu * b.mau + b.tu * a.mau;
            Tong.mau = a.mau * b.mau;
            return Tong;
        }
        public static PhanSo operator- (PhanSo a, PhanSo b)
        {
            PhanSo Hieu = new PhanSo();
            Hieu.tu = a.tu * b.mau - b.tu * a.mau;
            Hieu.mau = a.mau * b.mau;
            return Hieu;
        }
        public static PhanSo operator* (PhanSo a, PhanSo b)
        {
            PhanSo Tich= new PhanSo ();
            Tich.tu = a.tu * b.tu;
            Tich.mau = a.mau * b.mau;
            return Tich;
        }
        public static PhanSo operator/ (PhanSo a, PhanSo b)
        {
            PhanSo Thuong = new PhanSo();
            Thuong.tu = a.tu * b.mau;
            Thuong.mau = a.mau * b.tu;
            return Thuong;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo(3, 2);
            PhanSo b = new PhanSo(4,3);
            PhanSo c = new PhanSo();
            c = a + b;
            c.Xuat();
            c = a - b;
            c.Xuat();
            c = a * b;
            c.Xuat();
            c = a / b;
            c.Xuat();
            Console.ReadKey();
        }
    }
}
