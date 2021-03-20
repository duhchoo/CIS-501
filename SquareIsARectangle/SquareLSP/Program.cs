using System;
using System.Drawing;
using System.Reflection.Metadata;

namespace SquareLSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Height = 5;
            r1.Width = 4;
            Square s1 = new Square();
            s1.Side = 5;

            g2(r1);
            g2(s1);

            Console.ReadLine();

        }

        static void g(Rectangle r)
        {
            if (r.CalcArea() != 20)
            {
                throw new Exception("Bad Area!");
            }
            else
            {
                Console.Write($"For the Shape with sides: {r.Height} by {r.Width}, ");
                Console.WriteLine($"the Area is: {r.CalcArea()}");
            }
        }

        static void g2(Shape s)
        {
            Console.WriteLine($"the Area is: {s.CalcArea()}");
        }




    }
}
