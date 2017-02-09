using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect
{
    public class GuessingGame
    {
        int _remainingGuesses;
        int _answer;

        public GuessingGame()
        {

        }

        public void NewGame()
        {
            _remainingGuesses = 7;
            _answer = new Random().Next(101, 500);
            int guess;
            bool running = true;

            while (running && _remainingGuesses > 0)
            {
                Console.WriteLine("The answer is: {0}", _answer);
                Console.WriteLine("{0} guesses remaining", _remainingGuesses);
                Console.WriteLine("Please guesss a number between 100 and 500");
                guess = int.Parse(Console.ReadLine());

                if (guess == _answer)
                {
                    Console.WriteLine("You won!");
                    running = false;
                    Console.WriteLine("Press a key to exit");
                    Console.ReadKey();
                }
                else if (guess < _answer)
                {
                    Console.WriteLine("Too low, sorry :(");
                    Console.WriteLine("Press a key to try again");
                    _remainingGuesses--;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Too high, sorry :(");
                    Console.WriteLine("Press a key to try again");
                    _remainingGuesses--;
                    Console.ReadKey();
                }
            }

            
        }

    }
}
