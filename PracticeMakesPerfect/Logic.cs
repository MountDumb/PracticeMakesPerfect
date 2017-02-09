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

        // Opgave K.
        public void Swapper(int a, int b)
        {
            Console.WriteLine("a is {0} and b is {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a is {0} and b is {1}", a, b);
            Console.ReadKey();


            
        }

        public int CompareTwoInts(int a, int b)
        {
            return Math.Max(a, b);
        }

        public int compareThreeInbts(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

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

        public char CompareTwoChars(char firstChar, char secondChar)
        {
            //returns the alphabetically largest value (e.g. ‘a’ > ‘b’).
            //'a' == 96 and 'b' == 97, so keep in mind that alphabetially largest 
            //means numerically smallest.
            if (firstChar < secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

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
        public void CheckStringForEnglishLetters(string subject)
        {

        }

        
        

    }
}
