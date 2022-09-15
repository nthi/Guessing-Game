using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            int count = 4;
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"Try to guess the secret number ({count} guesses remaining):");
                string input = Console.ReadLine();
                int inputNumber;

                bool success = int.TryParse(input, out inputNumber);
                
                if (success) 
                {
                    if (inputNumber == secretNumber) 
                        {
                        Console.WriteLine($"You guessed correctly!");
                        break;
                        }
                    else 
                        {
                            if (inputNumber < secretNumber)
                            {
                            Console.WriteLine($"You guessed incorrectly: number too low!");
                            }
                            else
                            {
                            Console.WriteLine($"You guessed incorrectly: number too high!");
                            }   
                            count--;
                        } 
                    }

                
            }
       

        }
    }
}

//left off after finishing phase 6.
// Phase 7
// The program should be updated to...

// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.

// Phase 8
// The program should be updated to...

// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.