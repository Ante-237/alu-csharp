﻿using System;

class Program
{
        static void Main(string[] args)
        {
		string word = "Holberton";
		string word_three = word.Substring(0,3);
		string word_two =  word.Substring(7,2);
		string word_middle = word.Substring(1, 7);
		Console.WriteLine("First 3 letters: {0}", word_three);
		Console.WriteLine("Last 2 letters: {0}", word_two);
		Console.WriteLine("Middle word: {0}", word_middle);
        }
}