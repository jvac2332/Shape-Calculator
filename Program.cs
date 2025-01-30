//See http://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Joshua Vachachira
//CPSC-2300
// The assignment is about how to calculate volumes of shapes of an cube and a sphere on a user input

using System;

class ShapeCalculator
{
    static void Main()
    { 
        Console.WriteLine("============================");
        Console.WriteLine("            Shape Calculator");
        Console.WriteLine("=============================");
        //This is too be able to desiplay what app this is
        
        // What is the dimmensions of the cube?
        Console.WriteLine("Enter width of the of the cube: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter length of the cube: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height of the cube: ");
        double height = Convert.ToDouble(Console.ReadLine());
        // This will let you know of the dimmensions the cube has
        
        //What is volume of the cube?
        double cubeVolume = width * length * height;
        Console.WriteLine($"\nThe volume of the cube: {cubeVolume:F3} \n");
        // Finding the total volume of the cube
        
        // Find the radius of the sphere
        Console.WriteLine("Enter the radius of the sphere: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        // This way when double number we can estimate what the total radius of sphere might be 
        
        // Find the sphere Volume
        double sphereVolume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"\nThe volume of the sphere: {sphereVolume:F3}\n");
        // The sphere allows the user calculates the volume of a sphere for as an math formula
        
        // Find the total volume
        double totalVolume = cubeVolume + sphereVolume;
        Console.WriteLine($"The total volume of the both shapes is: {totalVolume:F3}\n");
        // Gives out the total of the sphere and cube volumes.
        Console.WriteLine("Thank you for using the shape calculator app.");


    }
}


