﻿﻿using System;

class Program
{
        static void Main(string[] args)
        {
		string word = "Holberton";
		string wordTwo  = word;
        string wordThree = word;
		Console.WriteLine("First 3 letters: {0}", word.Substring(0,3));
		Console.WriteLine("Last 2 letters: {0}", wordTwo.Substring(7,2));
		Console.WriteLine("Middle word: {0}", wordThree.Substring(1, 7));
        }
}
