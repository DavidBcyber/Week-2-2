using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, width; // the integers to find the area and perimeter for each length and width of the 
            Console.WriteLine("Enter the length of the rectangle: "); // this is the length for the rectangle to find the perimeter and the area 
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the rectangle: "); // this is the width for the rectangle to find the perimeter and the area 
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result:"); // resluts for each equation of the area and the perimeter
            Console.WriteLine("Area of the rectangle: " + (length * width)); // this equation will be able to find the total area of the rectangle
            Console.WriteLine("Perimenter of the rectangle: " + (length + length + width + width)); // This the equation for the total perimeter of the rectangle

            Console.ReadLine(); // Read line
        }
    }
}
