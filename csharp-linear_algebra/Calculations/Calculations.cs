using System;

class Program{

    public static void Main(string[] args){

        Console.WriteLine("working class");
        Console.WriteLine(" Length  :" + Pythagoras(64, 121));
    }

    public static float Pythagoras(int a, int b){

        int aS = (int) Math.Pow(a, 2);
        int bS = (int) Math.Pow(b, 2);

        int result = (int) Math.Sqrt(aS + bS);

        return result;
    }
}