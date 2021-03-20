using System;
using System.Drawing;

namespace SquareIsARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Square s1 = new Square();
            SquareSquare s2 = new SquareSquare();

            Console.WriteLine("Calling function with a rectangle: ");
            UserOfRectangle(r1);

            Console.WriteLine("Calling function with a square: ");
            UserOfRectangle(s1);

            Console.WriteLine("Calling function with a squareSquare: ");
            UserOfRectangle(s2);

            Console.ReadLine();
        }

        static void UserOfRectangle(Rectangle r)
        {
            r.Height = 4;
            r.Width = 5;

            if (r.CalculateArea() != 20)
            {
                throw new Exception("Bad Area!");
            }
            else
            {
                Console.Write($"For the Shape with sides: {r.Height} by {r.Width}, ");
                Console.WriteLine($"the Area is: {r.CalculateArea()}");
            }
        }






    }
}
