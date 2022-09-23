using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _21520638_Tuan1_Bai2_1
{
    class Matrix
    {
        public static bool CheckSNT(int a)
        {
            if(a<2)
                return false; 
            else if(a==2)
                return true;
            else
            {
                for(int i=2;i<=a/2;i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }
        public int Col { get; set; }   
        public int Row { get; set; }
        public int[,] arr;
        public void Input()
        {
            Console.WriteLine("Nhap so cot: ");
            Col=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong: ");
            Row=int.Parse(Console.ReadLine()); 
            arr=new int[Col,Row];
            for(int i=0;i<Col;i++)
            {
                for(int j=0;j<Row;j++)
                {
                    Console.WriteLine("arr[{0}][{1}])",i,j);
                    arr[i,j]=int.Parse(Console.ReadLine());
                }
            }
        }
        public void Output()
        {
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    Console.Write(arr[i,j] +" ");
                }
                Console.WriteLine();
            }
        }
        public void PrintSnt()
        {
            Console.WriteLine("SNT: ");
            for(int i=0;i<Col;i++)
            {
                for(int j=0;j < Row;j++)
                {
                    if(CheckSNT(arr[i,j]))
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
        }
        public bool Search()
        {
            int x;
            Console.WriteLine("Nhap so can tim: ");
            x = int.Parse(Console.ReadLine());
            for(int i=0;i<Col;i++)
            {
                for(int j=0;j<Row ;j++)
                {
                    if(arr[i,j]==x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix();
            a.Input();
            a.Output();
            a.PrintSnt();
            Console.WriteLine(a.Search());
            Console.ReadKey();
        }
    }
}
