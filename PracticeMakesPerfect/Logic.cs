﻿using System;
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
        public int CompareThreeInts(int a, int b, int c)
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
            //Only does postive numbers with "firstInt" higher than "secondInt"

            //int counter = 0;
            //int itterations = 1;

            //for (int i = 1; i <= firstInt; i++)
            //{
            //    if (secondInt * itterations == i)
            //    {
            //        counter += secondInt;
            //        itterations++;
            //    }
            //}

            //return firstInt - counter;

            while (firstInt >= secondInt)
            {
                firstInt -= secondInt;
            }

            return firstInt;
            
        }

        // exercise f:
        public int CountOccurrencesOfCharInString(string s, char c)
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

        // exercise h and i.
        public void CheckStringForEnglishLetters(string subject)
        {
            // English letters A through Z: 65-90
            // English letters a through z: 97-122
            string outputString = "";
            string disclaimer = "original string: " + '"' + subject + '"' + Environment.NewLine + "Position is zero indexed:" + Environment.NewLine;
            string stringOfTheDiscarded = "";

           //subject.Length is a Property, not a Method  Alternatively, use an int to count.
            for (int i = 0; i < subject.Length; i++)
            {
                if (subject[i] >= 65 && subject[i] <= 90 || subject[i] >= 97 && subject[i] <= 122)
                {
                    outputString += subject[i];
                }
                else
                {
                    stringOfTheDiscarded += ("[" + "'" + subject[i] + "'" + ", " + "'" + i + "'" + "]" + Environment.NewLine);
                }
            }
    
            Console.WriteLine(outputString);
            Console.WriteLine(disclaimer);
            Console.WriteLine(stringOfTheDiscarded);
        }

        // excercise j:

        public void CalcStuff()
        {
            List<int> numbers = new List<int>();
            bool running = true;
            int choice = 0;
             
            while (running)
            {
                Console.Clear();

                
                Console.WriteLine("Current amount of numbers: " + numbers.Count + Environment.NewLine);
                Console.WriteLine("Please add an integer or choose '0' to stop");

                choice = int.Parse(Console.ReadLine());

                if (choice < 0 || choice > 0)
                {
                    numbers.Add(choice);
                }
                else
                {
                    running = false;
                }
            }

            Console.WriteLine(GetSum(numbers));
            Console.WriteLine(GetAverage(numbers));
        }

        // exercise k:
        public void Swapper(int a, int b)
        {
            Console.WriteLine("a is {0} and b is {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a is {0} and b is {1}", a, b);
           
        }

        public int GetSum(List<int> numbers)
        {
            int output = 0;

            foreach (var item in numbers)
            {
                output += item;
            }

            return output;
        }

        public double GetAverage(List<int> numbers)
        {
            double output = 0;

            foreach (var item in numbers)
            {
                output += item;
            }

            return output / numbers.Count;
        }


    }
}
