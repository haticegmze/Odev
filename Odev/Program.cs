using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Program
    {
        static void Main(string[] args)
        {

         /*   Console.WriteLine(" Select the number of the shape you want to process?: ");
            Console.WriteLine("1.SQUARE");
            Console.WriteLine("2.RECTANGLE");
            Console.WriteLine("3.CİRCLE");
            Console.WriteLine("4.TRİANGLE");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (secim)
            {
                case 1:
                    Console.WriteLine("SQUARE");

                    break;
                case 2:
                    Console.WriteLine("RECTANGLE");
                    break;
                case 3:
                    Console.WriteLine("CİRCLE");
                    break;
                case 4:
                    Console.WriteLine("TRİANGLE");
                    break;
            }*/




            Square square = new Square();
            Console.Write("please enter tne line for Square : ");
            square.LineA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Square Area : " + square.AreaCalculation());
            Console.WriteLine(" Square perimeter : " + square.Perimeter());
            Console.WriteLine();
            Console.WriteLine();

            Circle circle = new Circle();
            Console.Write("please enter the line for Circle: ");
            circle.LineC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("circle area: " + circle.AreaCalculation());
            Console.WriteLine("circle perimeter: " + circle.Perimeter());
            Console.WriteLine();
            Console.WriteLine();

            Rectangle rectangle = new Rectangle();
            Console.Write("please enter tne lineA for Rectangle : ");
            rectangle.LineA = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter the lineB for Rectangle : ");
            rectangle.LineB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("rectangle area: " + rectangle.AreaCalculation());
            Console.WriteLine("rectangle perimeter " + rectangle.Perimeter());


        }

      
    }
}
