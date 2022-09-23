using System;

namespace HelloWorld
{
    public class SinhVien
    {
         string Ten ;
         int Toan;
         int Ly;
         int Hoa;
         public void Nhap()
        {
            Console.Write("Nhap ten: ");
            Ten=Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            Toan=Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem Ly: ");
            Ly = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            Hoa = Convert.ToInt32(Console.ReadLine());

        }
         internal  void Xuat()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Toan: " + Toan);
            Console.WriteLine("Ly: " + Ly);
            Console.WriteLine("Hoa: " + Hoa);
        }
        static int DTB()
        {
            return 1;
            
        }
          
    }
    public class Program
    {
        static int tinhtong(int a,int b)
        {
            return a+ b;
        }
        static void Main(string[] arg)
        {
            /* string[] a=new string[100];
             a[0] = "H";
             a[1] = "A";
             for(int i=0;i<a.Length;i++)
             {
                 Console.Write(a[i] +"\n");
             }*/
            /* SinhVien c= new SinhVien();
             c.Nhap();
             c.Xuat();*/
            /*SinhVien c= new SinhVien();
            Object a = c;
            SinhVien b= (SinhVien)a;
            b.Nhap();
            b.Xuat();*/
            int sum = int.Parse(Console.ReadLine());
           // string a = Console.ReadLine();
            string b = "";
            //string[] vs = int.Parse(b.Split(' '));
            SinhVien a=new SinhVien();
            a.
            Console.WriteLine(sum);
            Console.WriteLine("Xin chao ban {0}, {1}, {2}", 5, 1, "Binh");
            SinhVien.
        }
    }
   
}