using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21520638_Bai2_PDF
{
    internal class Program
    {
        class Mang
        {
            int sl;
            int[] MangDong;
            public void Nhap()
            {
                Console.WriteLine("Nhap so phan tu cua mang: ");
                sl = int.Parse(Console.ReadLine());
                MangDong = new int[sl];
                for(int i=0;i<sl;i++)
                {
                    Console.WriteLine("Nhap phan tu thu {0} trong mang: ", i);
                    MangDong[i]=int.Parse(Console.ReadLine()) ;

                }
            }
            public void Xuat()
            {
                Console.WriteLine("Cac phan tu trong mang la: ");
                foreach(int i in MangDong)
                {
                    Console.Write(i + " ");
                }
            }
            public int Tongle()
            {
                int Tong = 0;
                foreach(int i in MangDong)
                {
                    if (i % 2 == 1)
                        Tong += i;
                }
                return Tong;
            }
            static bool CheckSNT(int n)
            {
                if (n < 2)
                    return false;
                else if (n == 2)
                    return true;
                else
                {
                    for(int i=2;i<n/2;i++)
                    {
                        if(n%i==0) return false;
                    }
                }
                return true;
            }
            public int CountSNT()
            {
                int count = 0;
                foreach(int i in MangDong)
                {
                    if (CheckSNT(i) == true)
                        count++;
                }
                return count;
            }
            static bool SCP(int n)
            {
                for(int i=0; i<=Math.Sqrt(n);i++)
                {
                    if (i * i == n)
                        return true;
                }
                return false;
            }
            public int SCPMin()
            {
                int min = int.MaxValue;
                foreach(int i in MangDong)
                {
                    if(SCP(i)&&i<min)
                        min = i;
                }
                if (min == int.MaxValue)
                    return -1;
                return min;
            }
        }
        static void Main(string[] args)
        {
            Mang a = new Mang();
            a.Nhap();
            a.Xuat();
            Console.WriteLine("\nTong cac so le co trong mang la: " + a.Tongle());
            Console.WriteLine("\nCo {0} SNT trong mang.", a.CountSNT());
            Console.WriteLine("\nSo chinh phuong nho nhat trong mang la: " + a.SCPMin());
            Console.ReadKey();

        }
    }
}
