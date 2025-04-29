using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public class Geometry
    {
        public IAreaCalcutable GetRect(int unit1, Nullable<int> unit2=null)
        {
            //
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }
            return new Square() { Edge = unit1};
        }
    } 

    public interface IAreaCalcutable
    {
        int GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
          return Width * Height;
        }
    }

    public class Square : IAreaCalcutable //: Rectangle
    {
        //private int test;
        //public void setTest(int value)
        //{
        //    test = value;
        //}

        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }

        //public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }

        public int Edge { get; set; }

        public int GetArea()
        {
            return Edge * Edge;
        }
    }
}
