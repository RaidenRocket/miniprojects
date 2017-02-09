using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarrenDMiniProjectLoop
{
    class Program
    {
        protected static void Main(string[] args)
        {
            double num1, opt;
            double planet;

            Console.Write("------------------------");
            Console.Write("\nPlease Select a Planet :\n");
            Console.Write("------------------------");
            Console.Write("\n1-Mercury.\n2-Venus.\n3-Mars.\n4-Jupiter.\n5-Saturn. \n6-Uranus. \n7-Neptune \n8-Pluto\n");
            Console.Write("------------------------");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    {
                        Console.Write("Enter your weight:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.37;
                        Console.WriteLine("Your weight on Mercury would be: " + planet.ToString("0.0"));

                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Venus would be:" + planet.ToString("0.0"));

                        break;
                    }
                case 3: ;
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Mars would be:" + planet.ToString("0.0"));

                        break;
                    }

                case 4:
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Jupiter would be:" + planet.ToString("0.0"));

                        break;
                    }
                case 5:
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Jupiter would be:" + planet.ToString("0.0"));

                        break;
                    }
                case 6:
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Uranus would be:" + planet.ToString("0.0"));

                        break;
                    }
                case 7:
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Neptune would be:" + planet.ToString("0.0"));

                        break;
                    }
                case 8:
                    {
                        Console.Write("Enter your weight");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        planet = num1 * 0.88;
                        Console.Write("Your weight on Pluto would be:" + planet.ToString("0.0"));

                        break;
                    }
            }
        }
    }
}