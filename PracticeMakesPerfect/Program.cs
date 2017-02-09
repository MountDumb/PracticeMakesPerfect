using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect
{
    class Program
    {
        Logic logic = new Logic();
        GuessingGame game = new GuessingGame();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            bool running = true;
            string choice;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("1: Logic" + Environment.NewLine + "2: Guessing Game" + Environment.NewLine + "x: Exit");
                choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "1":
                        Console.WriteLine(logic.CompareTwoInts(2, 3));
                        Console.WriteLine(logic.CompareThreeInts(2, 3, 4));
                        Console.WriteLine(logic.CompareTwoChars('a', 'd'));
                        Console.WriteLine(logic.CalcModulo(21, 3));
                        Console.WriteLine("the letter 'u' occurs {0} times", logic.CountOccurrencesOfCharInString("bubbidibubub", 'u'));
                        logic.CheckStringForEnglishLetters("ab2c4&%abe{}||");
                        logic.Swapper(-3, 4);
                        Console.ReadKey();
                        break;
                    case "2":
                        game.NewGame();
                        Console.ReadKey();
                        break;
                    case "x":
                        running = false;
                        break;
                    default:
                        break;         
                    
                }
                   
            }
            
        }
    }
}
