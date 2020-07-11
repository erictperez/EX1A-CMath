using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1A_C
{
        class Program
        {
            static void Main(string[] args)
            {
                // Part 1
                // Implementation for the Circumference here
                Console.WriteLine("\nPart 1, Circumference and Area of a circle.");
                Console.Write("Enter a positive number greater than zero for the radius: ");
                string strradius = Console.ReadLine();
                int intradius = int.Parse(strradius);
                double circumference = 2 * Math.PI * intradius;
                Console.WriteLine($"The circumference is {circumference}");

                // Implementation for area here
                double area = Math.PI * Math.Pow(intradius, 2);
                Console.WriteLine($"The area is {area}");
                Console.WriteLine("This Completes Part 1, Calculating the Area & Circumference of a Circle.");



                // Part 2
                Console.WriteLine("\nPart 2, Volume of a Hemisphere.");
                Console.Write("Enter a positive number for the radius: ");
                string radius1 = Console.ReadLine();
                double dblradius1 = double.Parse(radius1);
                double sphere = 4 * Math.PI * Math.Pow(dblradius1, 3) / 3;
                double volume = sphere / 2;

                Console.WriteLine($"The volume is {volume}");
                Console.WriteLine($"This Completes Part 2, Calculating the Volume of a Hemisphere.");


                // Part 3
                Console.WriteLine("\nPart 3, Area of a Triangle (Heron's formula).");
                double s;
                double A, B, C;
                Console.Write("Enter a positive number for side a: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Enter a positive number for side b: ");
                B = double.Parse(Console.ReadLine());
                //string B = Console.ReadLine();
                Console.Write("Enter a positive number for side c: ");
                C = double.Parse(Console.ReadLine());
                //string C = Console.ReadLine();
                // Implementation here
                s = (A + B + C) / 2;
                area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));

                //Console.WriteLine($"The area is {area}");
                Console.WriteLine("Area = {0}", area);
                Console.WriteLine($"This Completes Part 3, Calculating the Area of a Triangle(Heron's formula).");


                // Part 4
                Console.WriteLine("\nPart 4, solving a quadratic equation.");
                Console.Write("Enter a positive number for A: ");
                string strA = Console.ReadLine();
                A = int.Parse(strA);
                Console.Write("Enter a positive number for B: ");
                string strB = Console.ReadLine();
                B = int.Parse(strB);
                Console.Write("Enter a positive number for C: ");
                string strC = Console.ReadLine();
                C = int.Parse(strC);
                double sqrtpart = B * B - 4 * A * C;

                double x, x1, x2, img;

                if (sqrtpart > 0)

                {

                x1 = (-B + System.Math.Sqrt(sqrtpart)) / (2 * A);

                x2 = (-B - System.Math.Sqrt(sqrtpart)) / (2 * A);

                Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);

                }

                else if (sqrtpart < 0)

                {

                sqrtpart = -sqrtpart;

                x = -B / (2 * A);

                img = System.Math.Sqrt(sqrtpart) / (2 * A);

                Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);

                }

                else

                {
    
                x = (-B + System.Math.Sqrt(sqrtpart)) / (2 * A);

                Console.WriteLine("One Real Solution: {0,8:f4}", x);

                }

                // 6x^2 + 11x - 35 = 0

                //Solve.Quadratic(6, 11, -35);



                // 5x^2 + 6x + 1 = 0

                //Solve.Quadratic(5, 6, 1);



                // 2x^2 + 4x + 2 = 0

                // Solve.Quadratic(2, 4, 2);



                // 5x^2 + 2x + 1 = 0

                //Solve.Quadratic(5, 2, 1);

                //Console.WriteLine($"The positive solution is {positive_num / denominator}");
                //Console.WriteLine($"The negative solution is {negative_num / denominator}");
            Console.WriteLine("Press any key to exit. Thank you for your time!");
            }
        }
}
