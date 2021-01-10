using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUSCLib.Math
{
    public class Point
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Constructor
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            x = p.x; y = p.y;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Tính khoảng cách của đối tượng đến gốc tọa độ O(0,0)
        /// </summary>
        /// <returns>Khoảng cách của đối tượng đến điểm O</returns>
        public double Distance()
        {
            double d = System.Math.Sqrt(x * x + System.Math.Pow(y, 2));
            return d;
        }

        /// <summary>
        /// Tính khoảng cách từ đối tượng đến điểm p(px, py)
        /// </summary>
        /// <param name="p">Điểm cần tính khoảng cách đến</param>
        /// <returns>Khoảng cách đến điểm p</returns>
        public double Distance(Point p)
        {
            double d = System.Math.Sqrt(System.Math.Pow(x - p.x, 2) + System.Math.Pow(y - p.y, 2));
            return d;
        }

        /// <summary>
        /// Hàm tính khoảng cách hai điểm AB
        /// </summary>
        /// <param name="A">Điểm thứ nhất</param>
        /// <param name="B">Điểm thứ hai</param>
        /// <returns>Khoảng cách AB</returns>
        public static double Distance(Point A, Point B)
        {
            return A.Distance(B);
            /*double d = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
            return d;*/
        }

        public override string ToString()
        {
            String output = String.Format("Toa do: ({0}, {1})", x, y);
            return output;
        }
        #endregion

    }
}
