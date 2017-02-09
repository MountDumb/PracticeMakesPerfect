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
            //Console.WriteLine(logic.CompareTwoInts(2, 3));
            //Console.WriteLine(logic.CompareThreeInts(2, 3, 4));
            //Console.WriteLine(logic.CompareTwoChars('a', 'd'));
            //Console.WriteLine(logic.CalcModulo(21, 3));
            //game.NewGame();
            //logic.CheckStringForEnglishLetters("ab%cDEF{}Ghijk'lMN!!");
            //logic.Swapper(-3, 4)
            Console.ReadKey();
        }
    }
}
