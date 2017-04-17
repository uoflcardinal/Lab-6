using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaration of variables
            string input = GetValidInput();
            string[] statement = Split(input);
            PigLatinTranslation(statement);

        }
        public static string GetValidInput()
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.Write("Please enter a word: ");
            string input = Console.ReadLine().ToLower();//Makes all input of the string lower case.
            return input;
        }

        public static void PigLatinTranslation(string[] input)
        {
            string addVowel = "way";
            string addConsonant = "ay";


            char[] vowel_list = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i].IndexOfAny(vowel_list) == 0)
                {
                    Console.WriteLine(input.Length + addVowel);
                }
                else
                {
                    string first = input[i].Substring(0, input[i].IndexOfAny(vowel_list));
                    string last = input[i].Substring(input[i].IndexOfAny(vowel_list));
                    Console.WriteLine(last + first + addConsonant);
                }
            }

        }
        public static string[] Split(string input)
        {
            String[] Characters = input.Split(' ');
            return Characters;
        }
    }
}
