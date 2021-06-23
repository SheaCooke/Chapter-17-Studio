using System;

namespace Chapter_17_Studio
{

	public class Circle
	{
        
        
            public static double Circumference(double radius)
            {
                return Math.PI * radius * 2;
            }

            public static double Area(double radius)
            {
                return Math.PI * radius * radius;
            }

            public static double Diameter(double radius)
            {
                return 2 * radius;
            }

        
    }
}
