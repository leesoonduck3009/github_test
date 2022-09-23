using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int x { get; set; }

        public int y { get; set; }
       
        public void Input()
        {
            Console.WriteLine("Nhap toa do x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y: ");
            y = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }
       
    }

    abstract class Shape
    {
        public abstract void Draw();
        public abstract void Input();
        public abstract float area { get; }
    }
    class Rectangle : Shape
    {
        int length;
        int width;
        Point A = new Point();
        Point B = new Point();
        Point C=new Point();    
        Point D=new Point();
       public override float area
        {
            get
            {
      
                return length*width;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Hinh Chu nhat!!");
            Console.WriteLine("Chieu dai: " + length );
            Console.WriteLine("chieu rong: " + width );
            Console.WriteLine("Toa do dinh A: ");
            A.Output();
            Console.WriteLine("Toa do dinh B: ");
            B.Output();
            Console.WriteLine("Toa do dinh C: ");
            C.Output();
            Console.WriteLine("Toa do dinh D: ");
            D.Output();
            Console.WriteLine("Dien tich: " + area);
        }
        public override void Input()
        {
            Console.WriteLine("Hinh Chu Nhat!!");
            Console.WriteLine("Nhap chieu dai: ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri dinh dau tien ");
            A.Input();
            B.x = A.x + width;
            B.y = A.y;
            C.x = A.y + length;
            C.y = A.y;
            D.x= A.x + width;
            D.y = A.y+length;

        }
    }
    class Circle : Shape
    {
        float R;
        Point I=new Point();
        public override float area
        {
            get { 
                return R* 3.14F; 
            }
        }
       

        public override void Draw()
        {
            Console.WriteLine("Day la hinh tron!!" );
            Console.WriteLine("Co tam: ");
            I.Output();
            Console.WriteLine("Ban Kinh: "+ R);
            Console.WriteLine("Dien tich: " + area);


        }
        public override void Input()
        {
            Console.WriteLine("Hinh Tron!!");
            Console.WriteLine("Nhap ban kinh R: ");
            R= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do tam I: ");
            I.Input();
        }

    }
    class Triangle : Shape
    {
       // float a, b, c;
        Point Pa=new Point();
        Point Pb=new Point();   
        Point Pc=new Point();
        public override float area
        { 
            get
            {
                return 0.5F * Math.Abs((Pb.x - Pa.x) * (Pc.y - Pa.y) - (Pc.x - Pa.x) * (Pb.y - Pa.y));
            } 
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh Tam Giac!!");
            Console.WriteLine("Toa do canh A: ");
            Pa.Output();
            Console.WriteLine("Toa do canh B: ");
            Pb.Output();
            Console.WriteLine("Toa do canh C: ");
            Pc.Output();
            Console.WriteLine("Dien tich: " + area);
        }
        public override void Input()
        {
            Console.WriteLine("Hinh Tam Giac!!");
            Console.WriteLine("Nhap toa do canh a: ");
            Pa.Input();
            Console.WriteLine("Nhap toa do canh b: ");
            Pb.Input();
            Console.WriteLine("Nhap toa do canh c: ");
            Pc.Input();
        }

    }



    internal class Program
    {
        public static void Nhap(Shape[] arr)
        {
            int x;
            Random rd= new Random();
           //Console.WriteLine("Nhap so phan tu: ");
            //n=int.Parse(Console.ReadLine());    
            // arr=new Shape[n];
            for (int i = 0; i < arr.Length; i++)
            {
                x = rd.Next(3);
                if (x == 0)
                {
                    arr[i] = new Rectangle();
                    arr[i].Input();
                    
                }
                else if(x == 1)
                {
                    arr[i] = new Triangle();
                    arr[i].Input();
                    
                }
                else
                {
                    arr[i] =new Circle();
                    arr[i].Input();
                   
                }
            }
        }
        public static void Xuat(Shape[] arr)
        {
            foreach (Shape s in arr)
                s.Draw();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu");
            Shape[] b = new Shape[int.Parse(Console.ReadLine())];

            Nhap(b);
            Xuat(b);
            Console.ReadKey();

        }
    }
}
// them file moiws
