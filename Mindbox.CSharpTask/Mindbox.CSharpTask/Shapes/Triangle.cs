using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.CSharpTask
{
    /// <summary>
    /// Triangle shape
    /// </summary>
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        /// <summary>
        /// Creates triangle from two sides and angle between them
        /// </summary>
        /// <returns>New triangle</returns>
        public static Triangle FromTwoSidesAndAngle(double sideA, double sideB, double degrees)
        {
            // Use cosine formula (a^2 = b^2 + c^2 − 2bc cosA) to calculate third side
            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos((Math.PI / 180) * degrees));
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle;
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates area of a triangle
        /// </summary>
        /// <returns>Area of a triangle</returns>
        public double GetArea()
        {
            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Calculates if triangle is right triangle
        /// </summary>
        /// <returns>Is right triangle</returns>
        public bool IsRightTriangle()
        {
            return Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
        }
    }
}
