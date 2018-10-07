using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
        bool guess = true;
            do
            {
                try
                {
                    Random ran = new Random();
                    int w, guessnumber, min = 1, max = 1000, number = 444, tries = 9;
                    string highlow;
                    Console.WriteLine("***** Guess My Number *****\n" +
                        "\n" +
                        "Choose from three option.\n" +
                        "\n" +
                        "1. Guess my Number from 1 to 10.\n" +
                        "2. Guess my Number from 1 to 1000\n" +
                        "3. You try let me guess your number from 1 to 100\n" +
                        "4. To Quit.");
                    w = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (w == 1)
                    {
                        tries = 4;
                        max = 10;
                        From1to10();
                    }
                    else if (w == 2)
                    {
                        number = ran.Next(100, 900);
                        From1to1000();
                    }
                    else if (w == 3)
                    {
                        max = 100;
                        Console.WriteLine("Choose a number from 1 to 100 for the Computer to guess.");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number >= 1 && number <= 100)
                        {
                            GuessComputer();
                        }
                        else
                        {
                            Console.WriteLine("Try Again");
                        }
                    }
                    else if (w == 4)
                    {
                        Console.WriteLine("Thanks for playing 'Guess My Number'");
                        Console.ReadKey();
                        guess = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again and pick only out of these option.");
                        Console.ReadKey();
                    }
                    void Congratulation()
                    {
                        Console.WriteLine("***Congratulation you guess the correct number***");
                        Console.ReadKey();
                    }
                    void From1to10()
                    {
                        tries = tries - 1; number = 6;
                        Console.WriteLine("Guess a number From " + min + " to " + max);
                        guessnumber = Convert.ToInt32(Console.ReadLine());
                        if (tries <= 0)
                        {
                            Console.WriteLine("You exceed the number of tries of guessing the number is " + number + "\n" +
                                "\n" +
                                "Thanks for playing.");
                        }
                        else if (guessnumber < number)
                        {
                            max = max - 2; min = min + 2; highlow = "low";
                            if ((max - number) <= 1 || max >= 10)
                            {
                                max = 1 + number;
                            }
                            if ((number - min) <= 1 || min <= 0)
                            {
                                min = number - 1;
                            }
                            Console.WriteLine("Your number was a little too " + highlow + " Try Again");
                            From1to10();
                        }
                        else if (guessnumber == number)
                        {
                            Congratulation();
                        }
                        else if (guessnumber > number)
                        {
                            max = max - 1; min = min + 1; highlow = "high";
                            if ((number - min) <= 1 || min <= 0)
                            {
                                min = number - 1;
                            }
                            if ((max - number) <= 1 || max >= 10)
                            {
                                max = 1 + number;
                            }
                            Console.WriteLine("Your number was a little too " + highlow + " Try Again");
                            From1to10();
                        }
                        else
                        {
                            Console.WriteLine("Try again");
                            From1to10();
                        }
                    }
                    void From1to1000()
                    {

                        tries = tries - 1;
                        Console.WriteLine("Guess a number From " + min + " to " + max);
                        guessnumber = Convert.ToInt32(Console.ReadLine());
                        if (tries <= 0)
                        {
                            Console.WriteLine("Your exceed the number of tries guessing number is " + number + "\n" +
                                "\n" +
                                "Thanks for playing.");
                        }
                        else if (guessnumber < number)
                        {
                            max = max - 50; min = min + 50; highlow = "low";
                            if ((max - number) <= 25 || max >= 1000)
                            {
                                max = 25 + number;
                            }
                            if ((number - min) <= 25 || min <= 0)
                            {
                                min = number - 25;
                            }
                            Console.WriteLine("Your number was too " + highlow + " Try Again");
                            From1to1000();
                        }
                        else if (guessnumber == number)
                        {
                            Congratulation();
                        }
                        else if (guessnumber > number)
                        {
                            max = max - 50; min = min + 50; highlow = "high";
                            if ((number - min) <= 25 || min <= 0)
                            {
                                min = number - 25;
                            }
                            if ((max - number) <= 25 || max >= 1000)
                            {
                                max = 25 + number;
                            }
                            Console.WriteLine("Your number was too " + highlow + " Try Again");
                            From1to1000();
                        }
                        else
                        {

                        }
                    }
                    void GuessComputer()
                    {
                        if (min <= 0)
                        {
                            min = 0;
                        }
                        if (max >= 100)
                        {
                            max = 100;
                        }
                        guessnumber = ran.Next(min, max);
                        Console.WriteLine("The Computer guess your number to be " + guessnumber + "\n" +
                            "\nChoose if the Computer choice was too high, too low, or on the money\n" +
                            "1. High \n2. Low \n3. Correct");
                        w = Convert.ToInt32(Console.ReadLine());
                        if ((w == 1 || w == 2) && (guessnumber == number)) 
                        {
                            Console.WriteLine("Stop being grummpy and give the computer a pat on the back");
                            Console.ReadKey();
                        }
                        else if (w == 3 && guessnumber != number)
                        {
                            Console.WriteLine("\nNice Try!!!");
                            if (number < guessnumber)
                            {
                                max = guessnumber - 1;
                                GuessComputer();
                            }
                            else
                            {
                                min = guessnumber + 1;
                                GuessComputer();
                            }
                        }
                        else if (w == 1)
                        {
                            if (number < guessnumber)
                            {
                                Console.WriteLine("\nNice Try!!!");
                                max = guessnumber - 1;
                                GuessComputer();
                            }
                            else
                            {
                                min = guessnumber + 1;
                                GuessComputer();
                            }
                        }
                        else if (w == 2)
                        {
                            if (guessnumber >= number)
                            {
                                Console.WriteLine("\nNice Try!!!");
                                max = guessnumber - 1;
                                GuessComputer();
                            }
                            else
                            {
                                min = guessnumber + 1;
                                GuessComputer();
                            }
                        }
                        else if (w == 3)
                        {
                            Console.WriteLine("***The Computer Celebrated***");
                            Console.ReadKey();
                        }
                        else
                        {
                            
                        }
                    }
                throw new Exception("\nStop pressing any keys. \nPlease only choose from the following option\n");
            }
            catch(Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }
            } while (guess) ;        
        }        
    }
}
