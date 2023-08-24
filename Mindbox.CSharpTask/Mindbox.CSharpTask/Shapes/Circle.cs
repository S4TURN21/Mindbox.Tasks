using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.CSharpTask
{
    /// <summary>
    /// Circle shape
    /// </summary>
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Calculates area of a circle
        /// </summary>
        /// <returns>Area of a circle</returns>
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
