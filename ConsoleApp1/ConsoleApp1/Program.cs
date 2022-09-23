using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public abstract void Draw();
        public abstract void Input();
    }
    class Rectangle : Shape
    {
        int length;
        int width;
        public override void Draw()
        {
            Console.WriteLine("Length: " );
            Console.WriteLine("Width: " );
        }
        public override void Input()
        {
            length = int.Parse(Console.ReadLine());
            width = int.Parse(Console.ReadLine());
        }
    }
    class Triangle : Shape
    {
        int R;
        
        public override void Draw()
        {
            Console.WriteLine("This is triangle: " + R);
        }
        public override void Input()
        {
           R= int.Parse(Console.ReadLine());
        }
    }
    class a
    { 
        public static void Nhap(Shape[] arr)
        {
            Console.WriteLine("Nhap so phan tu: ");
            //n=int.Parse(Console.ReadLine());    
           // arr=new Shape[n];
           for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Nhap loai: ");
                if(int.Parse(Console.ReadLine()) ==1)
                {
                    arr[i] =new Rectangle();
                    arr[i].Input();
                    arr[i].Draw();
                }
                else
                {
                    arr[i] = new Triangle();
                    arr[i].Input();
                    arr[i].Draw();
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu");
            Shape[] b=new Shape[int.Parse(Console.ReadLine())];
            
            a.Nhap(b);
            Console.ReadKey();
        }
    }
}
