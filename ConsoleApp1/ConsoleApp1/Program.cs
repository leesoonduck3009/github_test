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
        public static void Nhap(Shape[] arr,ref int n)
        {
            Console.WriteLine("Nhap so phan tu: ");
            n=int.Parse(Console.ReadLine());    
           // arr=new Shape[n];
            arr[0] = new Triangle();
            arr[1] = new Rectangle();
            arr[0].Input();
            arr[1].Input();
            arr[0].Draw();
            arr[1].Draw();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] b=new Shape[2];
            int n=2;
            a.Nhap(b,ref n);
            Console.ReadKey();
        }
    }
}
