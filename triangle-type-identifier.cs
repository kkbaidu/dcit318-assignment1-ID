using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the sides of the triangle:");

            Console.Write("Side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Side 3: ");
            string input3 = Console.ReadLine();

            double side1, side2, side3;
            bool isValid1 = double.TryParse(input1, out side1);
            bool isValid2 = double.TryParse(input2, out side2);
            bool isValid3 = double.TryParse(input3, out side3);

            if (isValid1 && isValid2 && isValid3)
            {
                string triangleType = DetermineTriangleType(side1, side2, side3);
                
                Console.WriteLine("The triangle is " + triangleType);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid lengths for all three sides.");
            }
        }

        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
