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
            int length, width; // int
            Console.WriteLine("Enter the length of the rectangle: "); // the length of the rectangle
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the rectangle: "); // the width of the rectangle
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result:"); // reluts for both equations
            Console.WriteLine("Area of the rectangle: " + (length * width)); // the total area
            Console.WriteLine("Perimenter of the rectangle: " + (length + length + width + width)); // the total of the perimenter

            Console.ReadLine(); // Read line
        }
    }
}
