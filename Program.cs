using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    class Program
    {
        // method for printing final result
        public static void print(double x, double y, string z)
        {
            Console.WriteLine("\n Your weight of " + x + " pounds on Earth would be " + y + " pounds on " + z + ".");

        }

        static void Main(string[] args)
        {
            //variables
            int menuChoice; // number of planet
            double earthWeight;// weight on the Earth
            double otherWeight;// weight for each planet
            string planet = "";// name of the planet

            // loop for running all program again and again
            do
            {
                // planet menu for user
                Console.WriteLine("\n      Menu of Planets");
                Console.WriteLine("      ==== == =======");
                Console.WriteLine("1.Jupiter   2.Mars    3.Mercury");
                Console.WriteLine("4.Neptune   5.Pluto   6.Saturn");
                Console.WriteLine("7.Uranus    8.Venus   9.<Quit>");
                Console.WriteLine("");

                // loop for entering menu choice
                do
                {
                    Console.Write("\n Enter your menu choice: ");
                                        
                    try
                    {
                        menuChoice = Int32.Parse(Console.ReadLine());// reading menu choice and converting to Integer
                    }

                    catch
                    {
                        menuChoice = 0; // if user enters letter or symbol, menuChoice equals zero
                    }
                   

                } while (!((menuChoice >= 1) && (menuChoice <= 9))); // loop are running until user will put number from 1 to 9


                // if user chooses 9.<Quit>, program says Goodbye, and goes to the end
                if (menuChoice == 9)
                {
                    Console.WriteLine("\n Have a great day! Goodbye!");
                }
                else
                {
                    // if menu choice isn't 9, program asks to enter weight on earth
                    do
                    {
                        Console.Write("\n Enter your weight on earth: ");

                        try
                        {
                            earthWeight = double.Parse(Console.ReadLine()); // weight converts to Double
                        }
                        catch
                        {
                            earthWeight = 0;// if user enters letter or symbol, menuChoice equals zero
                        }
                        
                    } while (earthWeight <= 0); // loop is running if Weight less than or equal to 0

                    // dependant of menu number, program calculates weight for each planet and prints result
                    switch (menuChoice)
                    {
                        case 1:// calculating for Jupiter

                            otherWeight = Math.Round(earthWeight * 2.64, 1);// calculating weight on planet and rounding it to 1 digits after point
                           
                            planet = "Jupiter";

                            print(earthWeight, otherWeight, planet);// call method for printing result

                            break;

                        case 2: // calculating for Mars

                            otherWeight = Math.Round(earthWeight * 0.38, 1);

                            planet = "Mars";

                            print(earthWeight, otherWeight, planet);

                            break;

                        case 3: // calculating for Mercury

                            otherWeight = Math.Round(earthWeight * 0.37, 1);

                            planet = "Mercury";

                            print(earthWeight, otherWeight, planet);

                            break;

                        case 4: // calculating for Neptune

                            otherWeight = Math.Round(earthWeight * 1.12, 1);

                            planet = "Neptune";

                            print(earthWeight, otherWeight, planet);

                            break;

                        case 5: // calculating for Pluto

                            otherWeight = Math.Round(earthWeight * 0.04, 1);

                            planet = "Pluto";

                            print(earthWeight, otherWeight, planet);

                            break;

                        case 6: // calculating for Saturn

                            otherWeight = Math.Round(earthWeight * 1.15, 1);

                            planet = "Saturn";

                            print(earthWeight, otherWeight, planet);

                            break;

                        case 7: // calculating for Uranus

                            otherWeight = Math.Round(earthWeight * 1.15, 1);

                            planet = "Uranus";

                            print(earthWeight, otherWeight, planet);
                            break;

                        case 8: // calculating for Venus

                            otherWeight = Math.Round(earthWeight * 0.88, 1);

                            planet = "Venus";

                            print(earthWeight, otherWeight, planet);
                            break;
                    }

                    Console.ReadLine();
                }

            } while (!(menuChoice == 9));// program stops running when user enters 9 (Quit)
            
            Console.ReadLine();

        }
    }
}