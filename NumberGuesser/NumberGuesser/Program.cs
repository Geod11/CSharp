using System;


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

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please choose an actual number: ");
                        continue;
                    }

                    guess = int.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong guess, try a different number: ");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");
                Console.WriteLine("");
                string answer;
                while (true)
                {
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
                        Console.WriteLine("Please type one of the options \"Y\" or \"N\"");
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
        static void GreetUser ()
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
