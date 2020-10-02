using System;
using System.Collections.Generic;
using System.Text;

namespace CubesAssessment.Library.Interfaces
{
    public interface ICubes
    {
        float CalculateCubesIntersection(float cube1Dimensions, float cube2Dimensions, float[] cube1Coords, float[] cube2Coords);
    }
}
