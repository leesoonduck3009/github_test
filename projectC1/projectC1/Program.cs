using System;

namespace PhucBinh
{
    abstract class Shape
    {
        public abstract void Draw();
        public abstract void Input();
    }
    class Rectangle: Shape
    {
        int length;
        int width;
        public override void Draw()
        {
            Console.WriteLine("Length: "+ length);
            Console.WriteLine("Width: " + width);
        }
        public override void Input()
        {
            length = int.Parse(Console.ReadLine());
            width = int.Parse(Console.ReadLine());  
        }
    }
    static void main()
    {
        Shape shape = new Rectangle();
        shape.Input();
        shape.Draw();   
    }
}