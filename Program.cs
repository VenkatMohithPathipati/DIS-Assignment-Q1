using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter your word");
            var word = RemoveVowels();// calls the function
            Console.WriteLine(word);
        }
        static string RemoveVowels()
        {
            var ans = Console.ReadLine();
            List<char> charsToRemove = new List<char>() { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };// creating a list with vowels
            foreach (char c in charsToRemove)
            {
                ans = ans.Replace(c.ToString(), String.Empty);//it replaces the exisiting vowel and remove it
            }
            return ans;
        }
}
    }

