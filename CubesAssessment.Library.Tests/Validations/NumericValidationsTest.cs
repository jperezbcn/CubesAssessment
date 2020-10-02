using CubesAssessment.Library.Validations;
using NUnit.Framework;
using System.Linq;

namespace CubesAssessment.Library.Tests.Validations
{
    [TestFixture]
    public class NumericValidationsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, TestName = "CheckFloatArray_Test0")]
        [TestCase(1, TestName = "CheckFloatArray_Test1")]
        [TestCase(2, TestName = "CheckFloatArray_Test2")]
        public void CheckFloatArray_Test(int testCase)
        {
            NumericValidations _validations = new NumericValidations();
            bool result;
            float[] outArray;

            switch (testCase)
            {
                case 0:
                    result = _validations.CheckFloatArray("0,0,0", out outArray);
                    Assert.IsTrue(result);
                    Assert.IsTrue(Enumerable.SequenceEqual(outArray, new float[3] { 0, 0, 0 }));
                    break;
                case 1:
                    result = _validations.CheckFloatArray("0,a,0", out outArray);
                    Assert.IsFalse(result);
                    break;
                case 2:
                    result = _validations.CheckFloatArray("-1,6,-12", out outArray);
                    Assert.IsTrue(result);
                    Assert.IsTrue(Enumerable.SequenceEqual(outArray, new float[3] { -1, 6, -12 }));
                    break;
            }
        }
    }
}
