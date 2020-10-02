using CubesAssessment.Library.Calculations;
using NUnit.Framework;

namespace CubesAssessment.Library.Tests.Calculations
{
    [TestFixture]
    public class CubesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, TestName = "CalculateCubesIntersection_Test0")]
        [TestCase(1, TestName = "CalculateCubesIntersection_Test1")]
        [TestCase(2, TestName = "CalculateCubesIntersection_Test2")]
        [TestCase(3, TestName = "CalculateCubesIntersection_Test3")]
        public void CalculateCubesIntersection_Test(int testCase)
        {
            Cubes _cubes = new Cubes();
            float result;

            switch (testCase)
            {
                case 0:
                    //Cube1 on the left of Cube2
                    result = _cubes.CalculateCubesIntersection(2, 2, new float[3] { 0, 0, 0 }, new float[3] { 1, 1, 1 });
                    Assert.IsTrue(result == 1);
                    break;
                case 1:
                    //Cube1 on the right of Cube2
                    result = _cubes.CalculateCubesIntersection(2, 2, new float[3] { 1, 1, 1 }, new float[3] { 0, 0, 0 });
                    Assert.IsTrue(result == 1);
                    break;
                case 2:
                    //Cube1 inside Cube2
                    result = _cubes.CalculateCubesIntersection(2, 4, new float[3] { 1, 1, 1 }, new float[3] { 1, 1, 1 });
                    Assert.IsTrue(result == 8);
                    break;
                case 3:
                    //Cube1 and Cube 2 do not collide
                    result = _cubes.CalculateCubesIntersection(2, 3, new float[3] { -5, -6, -7 }, new float[3] { 3, 1, 1 });
                    Assert.IsTrue(result == 0);
                    break;
            }
        }
    }
}
