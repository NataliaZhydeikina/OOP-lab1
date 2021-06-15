using System;
using GeometryLib;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line(-1, 1, -2, 2);
            Console.WriteLine("Line distance: " + line1.length());
            Console.WriteLine("Angle between a line and the x-axis: " + line1.getAngleOX());
            Console.WriteLine("Angle between a line and the y-axis: "+line1.getAngleOY());

            Line line2 = new Line(-7, -5, -12, 45);
            Console.WriteLine("Line2 distance: " + line2.length());
            Console.WriteLine("Angle between a line2 and the x-axis: " + line2.getAngleOX());
            Console.WriteLine("Angle between a line2 and the y-axis: " + line2.getAngleOY());
        }
    }
}
