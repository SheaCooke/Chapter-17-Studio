using System;

namespace Chapter_17_Studio
{
    class Program
    {
        
        static void CircleCalculations()
        {
            Console.WriteLine("Enter the radius of a circle: ");
            string input = Console.ReadLine();
            double r;
            while (!Double.TryParse(input, out r) || r <= 0)
            {
                Console.WriteLine("Please enter a number for the radius of a circle that is greater than 0: ");
                input = Console.ReadLine();
            }
            double area = Math.Round(Circle.Area(r),3);
            double c = Circle.Circumference(r);
            double d = Circle.Diameter(r);
            Console.WriteLine($"The area of a circle with a radius of {r} is: {area}");
            Console.WriteLine($"The circumference of a circle with a radius of {r} is: {c}");
            Console.WriteLine($"The diameter of a circle with a radius of {r} is: {d}");
            Console.WriteLine("How many miles per gallon does your car get?");
            string inputMPG = Console.ReadLine();
            double mpg;
            while (!Double.TryParse(inputMPG, out mpg) || mpg <= 0)
            {
                Console.WriteLine("Please enter a numerical value for MPG above 0: ");
                inputMPG = Console.ReadLine();
            }
            Console.WriteLine("Was the radius you entered previously in miles?");
            string inputMiles = Console.ReadLine().ToLower();
            if (inputMiles == "yes")
            {
                Console.WriteLine($"You will need {c / mpg} gallons to drive around this circle");

            }

            else
            {
                Console.WriteLine("Well if it was in in miles, ");
                Console.WriteLine($"You will need {c / mpg} gallons to drive around this circle");
            }

        }


        static void Main(string[] args)
        {
            CircleCalculations();
        }
    }
}
