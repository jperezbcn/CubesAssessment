using CubesAssessment.Library.Interfaces;
using System;

namespace CubesAssessment
{
    public class CubesApplication
    {
        private readonly INumericValidations _integerValidations;
        private readonly ICubes _cubes;

        public CubesApplication(INumericValidations integerValidations, ICubes cubes)
        {
            _integerValidations = integerValidations;
            _cubes = cubes;
        }

        public void Run()
        {
            StartProcess();
        }

        private void StartProcess()
        {

            float cubeSize1;
            float cubeSize2;
            float[] cubeCoords1;
            float[] cubeCoords2;
            string userInput;

            Console.Clear();

            Console.WriteLine("Please type 1st cube coordinates (X,Y,Z). Example: 2,3,6");
            userInput = Console.ReadLine();
            if (!_integerValidations.CheckFloatArray(userInput, out cubeCoords1))
            { 
                Console.WriteLine("Wrong coordinates values!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please type 1st cube dimension. Example: 8");
            userInput = Console.ReadLine();
            if (!_integerValidations.CheckDimension(userInput, out cubeSize1))
            {
                Console.WriteLine("Wrong dimension value!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please type 2nd cube coordinates (X,Y,Z). Example: 4,5,7");
            userInput = Console.ReadLine();
            if (!_integerValidations.CheckFloatArray(userInput, out cubeCoords2))
            {
                Console.WriteLine("Wrong coordinates values!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please type 2nd cube dimension. Example: 9");
            userInput = Console.ReadLine();
            if (!_integerValidations.CheckDimension(userInput, out cubeSize2))
            {
                Console.WriteLine("Wrong dimension value!");
                Console.ReadLine();
                return;
            }

            //Calculate intersection
            var volume = _cubes.CalculateCubesIntersection(cubeSize1, cubeSize2, cubeCoords1, cubeCoords2);

            if (volume > 0)
                Console.WriteLine("Cubes intersection volume is: " + volume);
            else
                Console.WriteLine("Cubes do not collide.");
            
            Console.ReadLine();
        }
    }
}
