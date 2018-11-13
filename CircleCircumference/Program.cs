using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            double circumference;
            string repeatProgram;
            bool repeat = true;
            Console.WriteLine("Welcome to Circle Tester");
            
            do
            {
                try
                {
                    {
                        Console.Write("Enter Radius ");
                        var radius = CalculateRadius();

                        var area = CalculateArea(radius);
                        circumference = CalculateCircumference(radius);
                   
                        
      // try   Console.WriteLine(radius.ToString());
                        Console.WriteLine("The circumference is: " + circumference.ToString("0.00"));
                        Console.WriteLine("The area is: " + area.ToString("0.00"));

                        Console.Write("\nDo you wish to continue (y/n): ");
                        repeatProgram = Console.ReadLine();
                        if (repeatProgram == "y" || repeatProgram == "Y")
                        {
                            repeat = true;
                        }
                        else
                        {
                            repeat = false;
                            Console.WriteLine("\nGoodbye!!");
                            Console.WriteLine("Press any key to exit");
                            Console.ReadLine();
                        }

                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please enter number");
                }
            } while (repeat);
        }

        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateRadius()
        {
            return double.Parse(Console.ReadLine());
        }
        
    }
}

        


        