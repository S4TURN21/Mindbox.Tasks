using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.CSharpTask
{
    /// <summary>
    /// Shapes factory
    /// </summary>
    public class Shapes
    {
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
