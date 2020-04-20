﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exercises.App.Samples
{
    public static class Strings
    {
        public static void Run()
        {
            //Reverse("Hello world");
            //Palindrome("A Santa at Nasa");
        }


        public static void Reverse(string input)
        {
            int lenght = input.Length;
            char[] chars = input.ToArray();
            char[] copy = new char[lenght];

            for (int i = 0, j = lenght - 1; i < lenght; i++, j--)
            {
                copy[j] = chars[i];
            }

            string result = new string(copy);

            Console.WriteLine(result);
            Console.ReadLine();
        }


        public static void Palindrome(string input)
        {
            bool isPalindrome = true;
            string inputClean = input.ToLower().Replace(" ", "");
            char[] chars = inputClean.ToArray();

            for (int i = 0, j = chars.Length - 1; i < chars.Length / 2; i++, j--)
            {
                if (chars[i] != chars[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine((isPalindrome?"Palindrome":"Not Palindrome"));
            Console.ReadLine();
        }
    }
}