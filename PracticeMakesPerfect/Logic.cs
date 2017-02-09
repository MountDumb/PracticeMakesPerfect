using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect
{
    public class Logic
    {
        public Logic()
        {

        }

        
        // exercise a:
        public int CompareTwoInts(int a, int b)
        {
            return Math.Max(a, b);
        }

        // exercise b:
        public int compareThreeInbts(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        // exercise c:
        public char CompareTwoChars(char firstChar, char secondChar)
        {
            //returns the alphabetically largest value (e.g. ‘a’ > ‘b’).
            //'a' == 96 and 'b' == 97, so keep in mind that alphabetically largest 
            //means numerically smallest. the chars are implicitly casted to int.
            if (firstChar < secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        // exercise d og e:
        public int CalcModulo(int firstInt, int secondInt)
        {
            int counter = 0;
            int itterations = 1;

            for (int i = 1; i <= firstInt; i++)
            {
                if (secondInt * itterations == i)
                {
                    counter += secondInt;
                    itterations++;
                }
            }

            return firstInt - counter;
        }

        // exercise f:
        public int CountOccurrencesofCharInString(string s, char c)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    counter++;
                }
            }

            return counter;
        }

        // exercise g:
        // Look at Class: "GuessingGame."

        // exercise h.
        public void CheckStringForEnglishLetters(string subject)
        {
            // English letters A through Z: 65-90
            // English letters a through z: 97-122
            string outputString = "";

            foreach (var item in subject)
            {
                if (item >= 65 && item <= 90 || item >= 97 && item <= 122 )
                {
                    outputString += item;
                }
            }
            Console.WriteLine(outputString);
        }



        // exercise k:
        public void Swapper(int a, int b)
        {
            Console.WriteLine("a is {0} and b is {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a is {0} and b is {1}", a, b);
            Console.ReadKey();



        }




    }
}
