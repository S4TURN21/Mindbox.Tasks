using NUnit.Framework;

namespace Mindbox.CSharpTask.Test
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleArea()
        {
            IShape circle = Shapes.CreateCircle(5);
            Assert.AreEqual(78.53981633974483, circle.GetArea(), 0.0001);
        }

        [Test]
        public void TriangleArea()
        {
            IShape triangle = Shapes.CreateTriangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 0.0001);
        }

        [Test]
        public void RightTriangleCheck()
        {
            IShape triangle = Shapes.CreateTriangle(3, 4, 5);
            Assert.IsTrue(((Triangle)triangle).IsRightTriangle());
        }

        [Test]
        public void TriangleCheck()
        {
            Triangle triangle = Triangle.FromTwoSidesAndAngle(2, 2, 45);
            Assert.AreEqual(1.531, triangle.SideC, 0.001);
        }
    }
}
