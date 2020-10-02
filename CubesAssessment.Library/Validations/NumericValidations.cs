using CubesAssessment.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubesAssessment.Library.Validations
{
    public class NumericValidations : INumericValidations
    {
        public bool CheckFloatArray(string coordinates, out float[] parsedNumbers)
        {
            parsedNumbers = new float[3];

            try
            {
                string[] coords = coordinates.Split(',');
                if (coords.Length != 3)
                    return false;

                //We consider negative numbers correct as these are coordinates, not sizes
                parsedNumbers = Array.ConvertAll(coords, s => float.Parse(s));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckDimension(string dimension, out float parsedDimension)
        {
            //Only positive numbers allowed as these are dimensions
            if (float.TryParse(dimension, out parsedDimension))
                return parsedDimension > 0;
            else
                return false;
        }
    }
}
