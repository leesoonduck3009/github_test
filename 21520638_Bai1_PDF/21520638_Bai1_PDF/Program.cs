using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21520638_Bai1_PDF
{
    class NgayThang
    {
        int Thang;
        int Nam;
        public void Nhap()
        {
            Console.WriteLine("Nhap thang: ");
            Thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            Nam = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            switch(Thang)
            {
                case 1:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 3:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 5:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 7:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 8:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 10:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 12:
                    Console.WriteLine("Thang {0} nam {1} co 31 ngay.", Thang, Nam);
                    break;
                case 2:
                    if(Nam%4!=0)
                        Console.WriteLine("Thang {0} nam {1} co 28 ngay.", Thang, Nam);
                    else
                        Console.WriteLine("Thang {0} nam {1} co 29 ngay.", Thang, Nam);
                    break;
                case 4:
                    Console.WriteLine("Thang {0} nam {1} co 30 ngay.", Thang, Nam);
                    break;
                case 6:
                    Console.WriteLine("Thang {0} nam {1} co 30 ngay.", Thang, Nam);
                    break;
                case 9:
                    Console.WriteLine("Thang {0} nam {1} co 30 ngay.", Thang, Nam);
                    break;
                case 11:
                    Console.WriteLine("Thang {0} nam {1} co 30 ngay.", Thang, Nam);
                    break;


            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NgayThang a = new NgayThang();
            a.Nhap();
            a.Xuat();
            Console.ReadKey();
        }
    }
}
