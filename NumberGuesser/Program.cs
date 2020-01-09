using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    public class Program
    {             
        static void Main(string[] args)
        {
            AppInfo();
            GreetUser();
                                                              
            while (true)
            {
                Console.Write("Please choose a number for the Lowest Limit of the Guessing Range: ");
                int lowerLimitNumber;
                
                while (true)
                {
                    try
                    {
                        string lowerLimit = Console.ReadLine();
                        lowerLimitNumber = int.Parse(lowerLimit);
                        
                        bool integerLimit = (lowerLimitNumber < int.MaxValue) ? true : false;

                        if (int.TryParse(lowerLimit, out lowerLimitNumber))
                        {
                            PrintColorMessage(ConsoleColor.Yellow, $"The Lowest Limit is {lowerLimitNumber}");
                            Console.WriteLine();
                            break;
                        }                        
                    }
                    catch (OverflowException)
                    {  
                        PrintColorMessage(ConsoleColor.Red, "The number is out of range, please try again: ");
                    }
                    catch (FormatException)
                    {
                        PrintColorMessage(ConsoleColor.Red, "The format is wrong, please type a whole number: ");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                while (true)
                {
                    Console.Write("Please choose a number for the Highest Limit of the Guessing Range: ");
                    int upperLimitNumber;
                    while (true)
                    {
                        try
                        {
                            string upperLimit = Console.ReadLine();
                            upperLimitNumber = int.Parse(upperLimit);

                            bool integerLimit = (upperLimitNumber > int.MinValue) ? true : false;
                            if (int.TryParse(upperLimit, out upperLimitNumber))
                            {
                                PrintColorMessage(ConsoleColor.Yellow, $"The Highest Limit is {upperLimitNumber}");
                                Console.WriteLine();
                                break;
                            }
                        }
                        catch (OverflowException)
                        {
                            PrintColorMessage(ConsoleColor.Red, "The number is out of range, please try again: ");
                        }
                        catch (FormatException)
                        {
                            PrintColorMessage(ConsoleColor.Red, "The format is wrong, please type a whole number: ");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    if (lowerLimitNumber < upperLimitNumber)
                    {
                        Console.Write($"Choose a number between {lowerLimitNumber} and {upperLimitNumber}: ");

                        Random random = new Random();
                        int correctNumber = random.Next(lowerLimitNumber, upperLimitNumber);
                        int guess = 0;
                        List<int> chosenNumbers = new List<int>();

                        while (guess != correctNumber)
                        {
                            string input = Console.ReadLine();
                            if (!int.TryParse(input, out guess))
                            {
                                PrintColorMessage(ConsoleColor.Red, "Please type a whole number number: ");
                                continue;
                            }

                            foreach (var item in chosenNumbers)
                            {
                                if (item == guess)
                                {
                                    PrintColorMessage(ConsoleColor.Red, "You tried this number already!");
                                    Console.WriteLine(" ");
                                    break;
                                }
                            }

                            guess = int.Parse(input);

                            chosenNumbers.Add(guess);

                            if (guess < correctNumber)
                            {

                                if (guess < lowerLimitNumber)
                                {
                                    PrintColorMessage(ConsoleColor.Blue, $"Out of range, choose a number between {lowerLimitNumber} and {upperLimitNumber}: ");
                                    continue;
                                }

                                else if (guess < correctNumber)
                                {
                                    PrintColorMessage(ConsoleColor.Blue, "Wrong guess, try a HIGHER number: ");
                                    continue;
                                }
                            }
                            else if (guess > correctNumber)
                            {

                                if (guess > upperLimitNumber)
                                {
                                    PrintColorMessage(ConsoleColor.Blue, $"Out of range, choose a number between {lowerLimitNumber} and {upperLimitNumber}: ");
                                    continue;
                                }

                                else if (guess > correctNumber)
                                {
                                    PrintColorMessage(ConsoleColor.Blue, "Wrong guess, try a LOWER number: ");
                                    continue;
                                }
                            }
                        }
                        PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");
                        Console.WriteLine("");

                        Console.Write($"You guessed in {chosenNumbers.Count} tries: ");
                        foreach (var item in chosenNumbers)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine("");

                        string answer;
                        while (true)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Play again? [Y or N] ");
                            answer = Console.ReadLine().ToUpper();

                            if (answer == "Y")
                            {
                                break;
                            }
                            else if (answer == "N")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("");
                                PrintColorMessage(ConsoleColor.Red, "Please type one of the options \"Y\" or \"N\"");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        PrintColorMessage(ConsoleColor.Red, "The Upper Limit must be of higher value than the Lower Limit. Try again.");
                        Console.WriteLine();
                        continue;
                    } 
                }
            }
        }
        static void AppInfo ()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.3";
            string appAuthor = "George Danilescu";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Application name: {appName} / Version: {appVersion} / Author: {appAuthor}");
            Console.ResetColor();
            Console.WriteLine("");
        }
        public static void GreetUser ()
        {            
            Console.Write("What is your name? ");
            string inputName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Hello {inputName}, let's play a number guessing game.");            
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }              
    }
}
