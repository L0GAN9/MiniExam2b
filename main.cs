using System;

class Program {
  public static double DetermineHypotenuse(double side1, double side2)
  {
    double hypot = Math.Sqrt((side1 * side1) + (side2*side2));
    return hypot;
  }
  public static void Main (string[] args) {
    Console.WriteLine ("Input Side 1");
    double side1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input Side 2");
    double side2 = Convert.ToDouble(Console.ReadLine());
    double hypot = DetermineHypotenuse(side1, side2);
    Console.WriteLine("Hypotenuse of Triangle");
    Console.WriteLine(hypot);
  }
}