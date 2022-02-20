using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Run Get App Info function to get info
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Create a new Random Object
                Random random = new Random();

                // Init correct number. 1 through 10 
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for guess
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct.. 
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure user input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "You need to enter a number.");

                        // Keep going
                        continue;

                    }

                    // Parse input into integer and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect number.");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Green, "You guessed correctly!");

                // Ask user to play again.
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get app info
        static void GetAppInfo()
        {
            // Set app  vars 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Justin Delille";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset color to default
            Console.ResetColor();
        }

        // Get user info
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input 
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.", inputName);
        }

        // Print color message 
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user to enter a number
            Console.WriteLine(message);

            // Reset color to default
            Console.ResetColor();
        }
    }
}
