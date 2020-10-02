using System;
using System.Collections.Generic;
using System.Text;

namespace CubesAssessment.Library.Interfaces
{
    public interface INumericValidations
    {
        bool CheckFloatArray(string coordinates, out float[] parsedNumbers);
        bool CheckDimension(string dimension, out float parsedDimension);
    }
}
