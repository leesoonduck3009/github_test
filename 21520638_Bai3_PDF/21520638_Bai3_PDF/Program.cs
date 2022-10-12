using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21520638_Bai3_PDF
{
    class Matrix
    {
        int col;
        int row;
        int[,] MT;
        public void Nhap()
        {
            Console.WriteLine("Nhap so cot: ");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so hang: ");
            row = int.Parse(Console.ReadLine());
            MT = new int[row, col];
            Console.WriteLine("Nhap ma tran: ");
            for (int i = 0; i < row; i++)
            {
                for(int j=0;j<col; j++)
                {
                    Console.Write("Matrix[{0}][{1}]: ", i, j);
                    MT[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(MT[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        public int Max()
        {
            int max = int.MinValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (max < MT[i, j])
                        max = MT[i, j];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = int.MaxValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (min > MT[i, j])
                        min = MT[i, j];
                }
            }
            return min;
        }
        public int MaxDong()
        {
            int dong = 0;
            int max = int.MinValue;
            int tong;
            int maxdong = 0;
            for (int i = 0; i < row; i++)
            {
                tong = 0;
                for (int j = 0; j < col; j++)
                {
                    tong += MT[i, j];
                }
                if (tong > max)
                {
                    max = tong;
                    maxdong = i;
                }
            }
            return maxdong;
        }
        public void XoaDong()
        {
            Console.WriteLine("Nhap dong can xoa: ");
            int k = int.Parse(Console.ReadLine());
            for(int i=k;i<row-1;i++)
            {
                for (int j = 0; j < col; j++)
                {
                    MT[i, j] = MT[i+1, j];
                }
            }
            --row;
           
        }
        public void XoaCotMax()
        {
            int colmax = -1;
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    if (this.Max() == MT[i,j])
                    {
                        colmax = j;
                        break;
                    }
                    
                }
                if (colmax != -1)
                    break;
            }
            for(int i = colmax;i<col-1;i++)
            {
                for (int j = 0; j < row; j++)
                {
                    MT[j, i] = MT[j, i+1];
                }
            }
            col--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix();
            a.Nhap();
            a.Xuat();
            Console.WriteLine("MAX: "+ a.Max());
            Console.WriteLine("MIN: "+ a.Min());
            Console.WriteLine("Dong co tong phan tu lon nhat la: " + a.MaxDong());
            a.XoaDong();
            Console.WriteLine("Ma tran sau khi xoa la: ");
            a.Xuat();
            a.XoaCotMax();
            Console.WriteLine("Ma tran sau khi xoa cot co so lon nhat la: ");
            a.Xuat();
            Console.ReadKey();
        }
    }
}
