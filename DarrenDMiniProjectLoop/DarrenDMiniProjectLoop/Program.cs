using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarrenDMiniProjectLoop
{
    class Program
    {
        private static void Main(string[] args)//ensures data remains within the program
        {
            
            int num1, opt;
            double planet;
            //below is the menu to select gravity modifier
            Console.Write("------------------------");
            Console.Write("\nPlease Select a Planet :\n");
            Console.Write("------------------------");
            Console.Write("\n1-Mercury");
            Console.Write("\n2-Venus");
            Console.Write("\n3-Mars");
            Console.Write("\n4-Jupiter");
            Console.Write("\n5-Saturn");
            Console.Write("\n6-Uranus");
            Console.Write("\n7-Neptune");
            Console.Write("\n8-Pluto");
            Console.Write("\n------------------------");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)//after input from 1 to 8, switch selects a case based on the input

            {
                case 1://this calculates your weight if you are in Mercury 
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 0.37;
                                Console.WriteLine("Your weight in Mercury is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                case 2://this calculates your weight if you are in Venus
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 0.88;
                                Console.WriteLine("Your weight in Venus is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                case 3:
                    ;//this calculates your weight if you are in Mars
                    {
                        
                            Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 0.38;
                                    Console.WriteLine("Your weight in Mars is equal to " + planet.ToString("0.0") + "lbs");

                                }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                            }

                            break;
                        }

                case 4://this calculates your weight if you are in Jupiter
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 2.64;
                                Console.WriteLine("Your weight in Jupiter is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                case 5://this calculates your weight if you are in Saturn
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 1.15;
                                Console.WriteLine("Your weight in Saturn is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                case 6://this calculates your weight if you are in Uranus
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 1.15;
                                Console.WriteLine("Your weight in Uranus is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                case 7://this calculates your weight if you are in Neptune
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 1.12;
                                Console.WriteLine("Your weight in Neptune is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                case 8://this calculates your weight if you are in Pluto
                    {
                        Console.Write("Enter your weight:");//weight data is inputted here
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 1000)//greater than 1000lbs
                        {
                            if (num1 > 0)//less than 0lbs
                            {
                                planet = num1 * 0.04;
                                Console.WriteLine("Your weight in Pluto is equal to " + planet.ToString("0.0") + "lbs");

                            }

                            else//unless the amount typed exceeded either choices 
                                Console.WriteLine("Invalid input, try again.");
                        }

                        break;
                    }
                    
            }
        }
    }
}