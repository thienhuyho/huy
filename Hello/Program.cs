using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HUSCLib.Math;
using HUSCLib.Geometry;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listShape = new List<Shape>();
            listShape.Add(new Circle(5, 5, 10));
            listShape.Add(new Rectangle());
            foreach (var item in listShape)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }

}
