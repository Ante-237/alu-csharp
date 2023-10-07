﻿using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine($"Percent: {string.Format("{0:P1}", percent * 100)}");
        Console.WriteLine($"Currency: {string.Format("{0:C2}", currency)}");
    }
}