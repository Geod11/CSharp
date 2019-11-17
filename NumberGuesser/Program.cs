using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AppInfo();
            GreetUser();
              
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("");
                Console.Write("Guess a number between 1 and 10: ");
                List<int> chosenNumbers = new List<int>();

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please choose an actual number: ");
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
                        
                        if (guess < 1)
                        {
                            PrintColorMessage(ConsoleColor.Blue, "Out of range, choose a number between 1 and 10: ");
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
                        
                        if (guess > 10)
                        {
                            PrintColorMessage(ConsoleColor.Blue, "Out of range, choose a number between 1 and 10: ");
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
        }

        static void AppInfo ()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
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
            Console.WriteLine($"Hello {inputName}, let's play a game.");            
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
        
    }
}
