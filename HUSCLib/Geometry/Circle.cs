using HUSCLib.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUSCLib.Geometry
{
    public class Circle : Shape
    {
        public Point CenterPoint { get; set; }
        public double Radius { get; set; }
        public Circle()
        {
            CenterPoint = new Point();
            Radius = 0;
        }
        public Circle(int x, int y, int r)
        {
            CenterPoint = new Point(x, y);
            Radius = r;
        }
        public Circle(Point p, int r)
        {
            CenterPoint = new Point(p);
            Radius = r;
        }
        public Circle(Circle c)
        {
            CenterPoint = new Point(c.CenterPoint);
            Radius = c.Radius;
        }
        public override double Perimeter()
        {
            return 2 * System.Math.PI * Radius;
        }
        public override double Area()
        {
            return System.Math.PI * System.Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Xác định ví trí tương đối giữa 2 hình tròn
        /// </summary>
        /// <param name="c2">Hình tròn cần xác đính vị trí với hình hiện tại</param>
        /// <returns>
        /// </returns>
        public RELATIVECIRCLE RelativePosition(Circle c2)
        {
            double c1c2 = CenterPoint.Distance(c2.CenterPoint);
            double r1Cr2 = Radius + c2.Radius;
            double r1Tr2 = System.Math.Abs(Radius - c2.Radius);
            if (c1c2 > r1Cr2)
                return RELATIVECIRCLE.LyingOutside;
            if (c1c2 == r1Cr2)
                return RELATIVECIRCLE.TouchingExternally;
            if (c1c2 == r1Tr2)
                return RELATIVECIRCLE.TouchingInternally;
            if (c1c2 < r1Tr2)
                return RELATIVECIRCLE.OneLyingInsideOther;
            return RELATIVECIRCLE.IntersectingAtTwoPoints;
        }

        public override string ToString()
        {
            return "Toi la hinh tron";
        }
    }

    public enum RELATIVECIRCLE
    {
        LyingOutside,
        TouchingExternally,
        TouchingInternally,
        OneLyingInsideOther,
        IntersectingAtTwoPoints
    }
}
