using System;

class Program{

    public static void Main(string[] args){

        Console.WriteLine("working class");
        Console.WriteLine(" Length  :" + Pythagoras(64, 121));
    }

    public static double Pythagoras(int a, int b){

        int AB = (int) Math.Pow(a, 2);
        int BC = (int) Math.Pow(b, 2);

        double AC = Math.Round(Math.Sqrt(AB + BC), 2);

        return AC;
    }
}