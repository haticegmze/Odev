using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Program
    {
        static void Main(string[] args)
        {
            
         /* Console.WriteLine(" Select the number of the shape you want to process?: ");
            Console.WriteLine("1.SQUARE");
            Console.WriteLine("2.RECTANGLE");
            Console.WriteLine("3.CİRCLE");
            Console.WriteLine("4.TRİANGLE");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); */
            
           


                    Square square = new Square(9);

                    Console.WriteLine("Square Area : " + square.AreaCalculation());
                    Console.WriteLine("Square perimeter : " + square.Perimeter());
                    Console.WriteLine();
                    Console.WriteLine();

                    Circle circle = new Circle(5);

                    Console.WriteLine("circle area: " + circle.AreaCalculation());
                    Console.WriteLine("circle perimeter: " + circle.Perimeter());
                    Console.WriteLine();
                    Console.WriteLine();

                    Rectangle rectangle = new Rectangle(9, 5);

                    Console.WriteLine("rectangle area: " + rectangle.AreaCalculation());
                    Console.WriteLine("rectangle perimeter " + rectangle.Perimeter());
                    Console.WriteLine();
                    Console.WriteLine();


                    Triangle triangle = new Triangle(20, 10, 10);

                    Console.WriteLine("triangle area: " + triangle.AreaCalculation());
                    Console.WriteLine("triangle perimeter: " + triangle.Perimeter());
                    Console.WriteLine();
                    Console.WriteLine();


                    Pentagon pentagon = new Pentagon(20, 5);

                    Console.WriteLine("pentagon area: " + pentagon.AreaCalculation());
                    Console.WriteLine("pentagon perimeter: " + pentagon.Perimeter());
                    Console.ReadLine();
            }


        }
    }


