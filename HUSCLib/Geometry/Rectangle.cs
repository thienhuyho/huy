using HUSCLib.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUSCLib.Geometry
{
    public class Rectangle : Shape
    {
        public Point LeftBottomPoint { get; set; }
        public Point RightTopPoint { get; set; }
        public override double Perimeter()
        {
            throw new NotImplementedException();
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Toi la hinh chu nhat";
        }
    }
}
