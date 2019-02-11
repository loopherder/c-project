using System;


// namespace
namespace NumberGuesser
{   // main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //set app vars
            string appName = "number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "John Bryant";

            // change text color
            Console.ForegroundColor = ConsoleColor.DarkRed;

            // write out app info 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();

            // ask users name
            Console.WriteLine("what is your name traveler?");

            // get user input
            string inputName = Console.ReadLine();



            Console.WriteLine("hello {0}, Let's play a game...", inputName);

            while (true)
            {
                // init correct number
                //int correctNumber = 7;

                //createa a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);
                // init guess var;
                int guess = 0;

                // ask user for number
                Console.WriteLine("guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber) {
                    // get users input
                    string input = Console.ReadLine();

                    // make sure it is a number
                    if (!int.TryParse(input, out guess)) {
                        // change text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // tell use rits not a number
                        Console.WriteLine("sorry traveler, that is not a number - enter an actual number");

                        // reset text color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }


                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        // change text color
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        // tell user number is worng 
                        Console.WriteLine("Wrong Number, please try again");


                        // reset text color
                        Console.ResetColor();
                    }
                }

                // output success message
                // change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // tell user its the right number
                Console.WriteLine("O U T S T A N D I N G");

                // reset text color
                Console.ResetColor();

                // ask user to play again
                console.writeline("play again wanderer? [Y or N]");

                    //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}