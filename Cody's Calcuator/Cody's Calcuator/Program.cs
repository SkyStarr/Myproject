using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cody_s_Calcuator
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput = '\0';
            do
            {
                // On start up menu title.
                Console.WriteLine("            Cody's Calculator");
                Console.WriteLine();
                Console.WriteLine("Please press any key to begin.");
                Console.ReadKey();

                // Now we ask the console to clear the above title.
                Console.Clear();

                // Here we're able to select calculating Options
                Console.WriteLine("Please select an option.");
                Console.WriteLine();
                Console.WriteLine("Press [+] key to Add");
                Console.WriteLine("Press [-] key to Subtract");
                Console.WriteLine("Press [*] key to Multiply");
                Console.WriteLine("Press [/] key to Divide");

                float num01 = 0;
                float num02 = 0;
                float result;
                char mathFunc = Console.ReadKey().KeyChar;
                switch (mathFunc)
                {

                    case '+':

                        Console.Clear();
                        Console.WriteLine("Please enter first number to be added and hit enter\n");

                        if (!float.TryParse(Console.ReadLine(), out num01))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        Console.WriteLine("\nPlease enter second number to be added and hit enter\n");

                        if (!float.TryParse(Console.ReadLine(), out num02))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        result = (num01 + num02);
                        Console.Write("\nYour result = " + result);
                        Console.WriteLine("\n\nWould you like to continue adding to current result? Y / N.");
                        Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                        char charChoice = Console.ReadKey(true).KeyChar;

                        if (charChoice == 'y')
                        {

                            while (charChoice == 'y')
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter next number to be added to current result and hit enter\n");

                                if (!float.TryParse(Console.ReadLine(), out num01))
                                {
                                    Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }

                                result = (num01 + result);
                                Console.Write("\nYour new result = " + result);
                                Console.WriteLine("\n\nWould you like to continue adding to current result? Y / N.");
                                Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                                charChoice = Console.ReadKey().KeyChar;
                            }
                        }
                        break;

                    case '-':

                        Console.Clear();
                        Console.WriteLine("Please enter your first number and hit enter: \n[Perferably largest number first]\n");

                        if (!float.TryParse(Console.ReadLine(), out num01))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        Console.WriteLine("\nPlease enter second number and hit enter: \n[Perferably not larger than first number]\n");

                        if (!float.TryParse(Console.ReadLine(), out num02))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        result = (num01 - num02);
                        Console.Write("\nYour result = " + result);
                        Console.WriteLine("\n\nWould you like to continue subtracting to current result? Y / N.");
                        Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                        char charChoice1 = Console.ReadKey(true).KeyChar;

                        if (charChoice1 == 'y')
                        {

                            while (charChoice1 == 'y')
                            {
                                Console.Clear();
                                Console.WriteLine("\nPlease enter you next number and hit enter: \n[Perferably not larger than your current result]\n");

                                if (!float.TryParse(Console.ReadLine(), out num01))
                                {
                                    Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }

                                result = (result - num01);
                                Console.Write("\nYour new result = " + result);
                                Console.WriteLine("\n\nWould you like to continue subtracting from current result? Y / N.");
                                Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                                charChoice1 = Console.ReadKey().KeyChar;
                            }
                        }
                        break;

                    case '*':

                        Console.Clear();
                        Console.WriteLine("Please enter your first number to be multiplied and hit enter\n");

                        if (!float.TryParse(Console.ReadLine(), out num01))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        if (0 == num01)
                        {
                            Console.WriteLine("\nMultiplying by 0 will always be 0!\nPlease try again.");
                            Console.WriteLine("\nPlease hit enter to continue.");
                            Console.ReadLine();
                            break;
                        }

                        Console.WriteLine("\nPlease enter second number to be multiplied and hit enter\n");

                        if (!float.TryParse(Console.ReadLine(), out num02))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        if (0 == num02)
                        {
                            Console.WriteLine("\nMultiplying by 0 will always be 0!\nPlease try again.");
                            Console.WriteLine("\nPlease hit enter to continue.");
                            Console.ReadLine();
                            break;
                        }

                        result = (num01 * num02);
                        Console.Write("\nYour result = " + result);
                        Console.WriteLine("\n\nWould you like to continue multiplying to current result? Y / N.");
                        Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                        char charChoice2 = Console.ReadKey(true).KeyChar;

                        if (charChoice2 == 'y')
                        {

                            while (charChoice2 == 'y')
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter you next number to be multiplied to current result and hit enter\n");

                                if (!float.TryParse(Console.ReadLine(), out num01))
                                {
                                    Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }

                                if (0 == num01)
                                {
                                    Console.WriteLine("\nMultiplying by 0 will always be 0!\nPlease try again.");
                                    Console.WriteLine("\nPlease hit enter to continue.");
                                    Console.ReadLine();
                                    break;
                                }

                                result = (result * num01);
                                Console.Write("\nYour new result = " + result);
                                Console.WriteLine("\n\nWould you like to continue multiplying to current result? Y / N.");
                                Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                                charChoice2 = Console.ReadKey().KeyChar;
                            }
                        }
                        break;

                    case '/':

                        Console.Clear();
                        Console.WriteLine("Please enter your first number and hit enter: \n[Perferably largest number first]\n");

                        if (!float.TryParse(Console.ReadLine(), out num01))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        if (0 == num01)
                        {
                            Console.WriteLine("Cannot divide by 0!");
                            Console.WriteLine("\nPlease hit enter to continue.");
                            Console.ReadLine();
                            break;
                        }

                        Console.WriteLine("\nPlease enter second number and hit enter: \n[Perferably not larger that first number]\n");

                        if (!float.TryParse(Console.ReadLine(), out num02))
                        {
                            Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        if (0 == num02)
                        {
                            Console.WriteLine("\nCannot divide by 0!");
                            Console.WriteLine("\nPlease hit enter to continue.");
                            Console.ReadLine();
                            break;
                        }

                        result = (num01 / num02);
                        Console.Write("\nYour result = " + result);
                        Console.WriteLine("\n\nWould you like to continue dividing from current result? Y / N.");
                        Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                        char charChoice3 = Console.ReadKey(true).KeyChar;

                        if (charChoice3 == 'y')
                        {

                            while (charChoice3 == 'y')
                            {
                                Console.Clear();
                                Console.WriteLine("Your current result = " + result);
                                Console.WriteLine("\nPlease enter you next number and hit enter: \n[Perferably not larger than your current result]");

                                if (!float.TryParse(Console.ReadLine(), out num01))
                                {
                                    Console.WriteLine("\nError, letters can't be used! Please try again.\n\nPress enter to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }

                                if (0 == num01)
                                {
                                    Console.WriteLine("Cannot divide by 0!");
                                    Console.WriteLine("\nPlease hit enter to continue.");
                                    Console.ReadLine();
                                    break;
                                }

                                result = (result / num01);
                                Console.Write("\nYour new result = " + result);
                                Console.WriteLine("\n\nWould you like to continue dividing from current result? Y / N.");
                                Console.WriteLine("\nPressing any key other than [y] will take you to the return menu.");
                                charChoice3 = Console.ReadKey().KeyChar;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("\nError occurred! Please try again.\n\nPress enter to continue");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
                Console.WriteLine("Return to the menu? Y / N");
                Console.WriteLine("\n\nPressing any key other than [y] will close the calculator.");
                userInput = Console.ReadKey(true).KeyChar;
                Console.Clear();

            } while (userInput == 'y');
        }
    }
}
