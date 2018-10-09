using System;

namespace Travel2TheSunWithSoundSpeedInWater
{
    class Program
    {
        static void Main(string[] args)
        {
			int distance2SunFromEarth = 149600000;
			short speedOfSound20DegreeWater = 1481;
			double timeNeeded = (double)distance2SunFromEarth / speedOfSound20DegreeWater;


            Console.WriteLine($"Time needed:{timeNeeded}");

        }
    }
}
