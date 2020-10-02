using CubesAssessment.Library.Interfaces;
using System.Linq;

namespace CubesAssessment.Library.Calculations
{
    public class Cubes : ICubes
    {
        public float CalculateCubesIntersection(float cube1Dimensions, float cube2Dimensions, float[] cube1Coords, float[] cube2Coords)
        {
            float[] intersection = new float[3];
            //Check intersection in three axis
            intersection[0] = CheckOneDimension(cube1Dimensions, cube2Dimensions, cube1Coords[0], cube2Coords[0]);
            intersection[1] = CheckOneDimension(cube1Dimensions, cube2Dimensions, cube1Coords[1], cube2Coords[1]);
            intersection[2] = CheckOneDimension(cube1Dimensions, cube2Dimensions, cube1Coords[2], cube2Coords[2]);

            //Volume calculation
            //If 1 of the axis do not intersect, total volume will be 0
            return intersection[0] * intersection[1] * intersection[2];
        }

        private float CheckOneDimension(float cube1Dimension, float cube2Dimension, float cube1Coord, float cube2Coord)
        {
            //Max and min values for both cubes
            float cube1Max = cube1Coord + cube1Dimension / 2;
            float cube1Min = cube1Coord - cube1Dimension / 2;
            float cube2Max = cube2Coord + cube2Dimension / 2;
            float cube2Min = cube2Coord - cube2Dimension / 2;

            //Check whether cubes intersect or not (for 1 axis) 
            if (cube1Min < cube2Max && cube2Min < cube1Max)
            {
                //Find intersection size
                float[] values = new float[4] { cube1Min, cube1Max, cube2Min, cube2Max };
                values = values.Except(new float[] { values.Max() }).ToArray();
                values = values.Except(new float[] { values.Min() }).ToArray();

                return values.Max() - values.Min();
            }
            else
                return 0;
            
        }
    }
}
