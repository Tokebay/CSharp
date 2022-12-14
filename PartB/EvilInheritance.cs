using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    internal class EvilInheritance
    {
    }

    public interface IShape
    {
        int CalcSquare();
    }

    public class Rect : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcSquare()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public int SideLength { get; set; }
        public int CalcSquare()
        {
            return SideLength * SideLength;
        }
    }

    public static class AreaCalc
    {
        /*
        public static int CalcSquare(Square square)
        {
            return square.Height * square.Height;
        }

        public static int CalcSquare(Rect rect)
        {
            return rect.Width * rect.Height;
        }
        */
    }
}
