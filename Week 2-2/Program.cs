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
            int length, width;
            Console.WriteLine("Enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result:");
            Console.WriteLine("Area of the rectangle: " + (length * width));
            Console.WriteLine("Perimenter of the rectangle: " + (length + length + width + width));

            Console.ReadLine();
        }
    }
}
