using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Student
{
    public class SinhVien : IComparable
    {
        public string name { get; set; }
        public int mssv { get; set; }
        public string lop { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string name, int mssv, string lop)
        {
            this.name = name;
            this.mssv = mssv;
            this.lop = lop;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap mssv: ");
            mssv = int.Parse(Console.ReadLine());
            Console.Write("Nhap lop: " );
            lop = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ten: {0}", name);
            Console.WriteLine("MSSV: {0}", mssv);
            Console.WriteLine("Lop: {0}", lop);
        }
        public override string ToString()
        {
            return name + "/" + mssv + "/" + lop + "\n";
        }
        public int CompareTo(object temp)
        {
            SinhVien sv = temp as SinhVien;
            return this.mssv.CompareTo(sv.mssv);
        }
    }
    public class LopHoc : IEnumerable
    {
        public List<SinhVien> DSSV { get; set; }
        public int sl { get; set; }
        public LopHoc()
        {
            DSSV = new List<SinhVien>();
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so luong sv: ");
             sl = int.Parse(Console.ReadLine());
            for(int i=0;i<sl;i++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine("Sinh vien thu: {0}", i);
                sv.Nhap();
                DSSV.Add(sv);
            }    
        }
        public void Xuat()
        {
            foreach(SinhVien sv in DSSV)
            {
                Console.Write("\n");
                sv.Xuat();
            }
        }
        public void Sort()
        {
            DSSV.Sort();
        }
        public void Clear()
        {
            DSSV.Clear();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return DSSV.GetEnumerator();
        }
        public  void LuuSV()
        {
            for (int i = 0; i < sl; i++)
            {
                if (File.Exists("data.txt") == false)
                 File.WriteAllText("data.txt", DSSV[i].ToString());
               else
                    File.AppendAllText("data.txt", DSSV[i].ToString());
            }
                
        }
        public void XuatFile()
        {
            string[] str = File.ReadAllLines("data.txt");
            Console.WriteLine("Du lieu co trong file la: ");
            for(int i=0;i<str.Length; i++)
            {
                string[] str2 = str[i].Split('/');
                Console.WriteLine("Ten: " + str2[0]);
                Console.WriteLine("MSSV: " + str2[1]);
                Console.WriteLine("Lop: " + str2[2]);
            }
        }
        public bool Search(int ms)
        {
            string[] str = File.ReadAllLines("data.txt");
            for (int i = 0; i < str.Length; i++)
            {
                string[] str2 = str[i].Split('/');
                if (int.Parse(str2[1]) == ms)
                {
                     return true;
                }
            }
                return false;
        }
        public void AddSV()
        {
            Console.Write("Nhap mssv can them: ");
            int ms = int.Parse(Console.ReadLine());
            if(this.Search(ms))
            {
                Console.WriteLine("Da co sinh vien trong file");
                
            }
            else
            {
                DSSV.Clear();
                string[] str = File.ReadAllLines("data.txt");

                for (int i = 0; i < str.Length; i++)
                {
                    string[] str2 = str[i].Split('/');
                    SinhVien temp = new SinhVien(str2[0], int.Parse(str2[1]), str2[2]);
                    DSSV.Add(temp);
                }
                Console.WriteLine("Nhap ten: ");
                string ten1 = Console.ReadLine();
                Console.WriteLine("Nhap lop: ");
                string lop1= Console.ReadLine();
                SinhVien a = new SinhVien(ten1,ms,lop1);
                DSSV.Add(a);
                this.Sort();
                File.WriteAllText("data.txt", DSSV[0].ToString());
                for (int i = 1; i < DSSV.Count; i++)
                {
                    File.AppendAllText("data.txt", DSSV[i].ToString());
                }
            }
        }
        public void Update()
        {
            Console.Write("Nhap mssv can cap nhat: ");
            int ms = int.Parse(Console.ReadLine());
            if (this.Search(ms)==false)
            {
                Console.WriteLine("Chua co sinh vien trong file");
                return;

            }
           
            DSSV.Clear();
            string[] str = File.ReadAllLines("data.txt");
           
            for (int i = 0; i < str.Length; i++)
            {
                string[] str2 = str[i].Split('/');
                SinhVien temp = new SinhVien(str2[0], int.Parse(str2[1]), str2[2]);
                DSSV.Add(temp);
            }
            for(int i=0;i<DSSV.Count;i++)
            {
                if(DSSV[i].mssv==ms)
                {
                    Console.WriteLine("Nhap ten moi cua sinh vien: ");
                    DSSV[i].name = Console.ReadLine();
                    Console.WriteLine("Nhap lop moi cua sinh vien: ");
                    DSSV[i].lop = Console.ReadLine();
                    break;
                }
            }
            File.WriteAllText("data.txt", DSSV[0].ToString());
            for(int i=1;i<DSSV.Count;i++)
            {
                File.AppendAllText("data.txt", DSSV[i].ToString());
            }
            
        }
    }
    
    internal class Program
    {
        public static void MenuScript()
        {
            Console.WriteLine("1.Them sinh vien.");
            Console.WriteLine("2.Xuat thong tin co trong file.");
            Console.WriteLine("3.Cap nhat thong tin sinh vien.");
            Console.WriteLine("0.Thoat chuong trinh.");
            Console.Write("Nhap lua chon:");
        }
        
        static void Main(string[] args)
        {
            LopHoc a = new LopHoc();
            int choice = 1;
            while(choice!=0)
            {
                MenuScript();
             choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        a.AddSV();
                       
                        break;
                    case 2: 
                        a.XuatFile();
                        break;
                    case 3:
                        a.Update();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                }
            }    
            
         /*   a.Nhap();
            a.Sort();
           
            
            
            Console.WriteLine("Thong tin file moi duoc cap nhat la: ");
            a.XuatFile();*/
            Console.ReadKey();
        }
    }
}
