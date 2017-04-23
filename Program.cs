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
            //Declaration of variables and methods:
            string input = ValidInput();
            string[] characters = Split(input);
            PigLatinTranslation(characters);
        }
        public static string ValidInput()
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.Write("Please enter a word: ");
            string input = Console.ReadLine().ToLower();//Makes all input of the string lower case.
            return input;//returns input back to Main
        }
         public static string[] Split(string input)
        {
            //Takes input of string and splits them into an array of characters.
            String[] Characters = input.Split(' ');
            return Characters;
        }
        public static void PigLatinTranslation(string[] input)
        {
            //Declaration of variables.
            string addVowel = "way";
            string addConsonant = "ay";
            char[] vowel_list = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < input.Length; i++)
            {
                //Checks to see if any of the first character of a word starts with a vowel.
                if (input[i].IndexOfAny(vowel_list) == 0)
                {
                    //If true then executes printing the word that starts with a vowel joins string with "way".
                    Console.Write(input[i] + addVowel + " ");
                }
                else
                {
                     //Else is false and the first word starts with a consonant.
                    string first = input[i].Substring(0, input[i].IndexOfAny(vowel_list));
                    string last = input[i].Substring(input[i].IndexOfAny(vowel_list));
                    //Takes consonants and put them after the first vowel of string then joing string with "ay".
                    Console.Write(last + first + addConsonant + " ");
                }
            }
        }       
    }
}
