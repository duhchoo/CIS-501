using System;
using System.Collections.Generic;
using System.Text;

namespace SquareLSP
{
    public abstract class Shape
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public abstract void Draw();
        public abstract int CalcArea();
    }

    public class Rectangle : Shape
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override int CalcArea()
        {
            return Height * Width;
        }
    }

    public class Square : Shape
    {
        public int Side { get; set; }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override int CalcArea()
        {
            return Side * Side;
        }
    }
}
