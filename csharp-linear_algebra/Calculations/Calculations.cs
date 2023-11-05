using System;

class Program{

    public static void Main(string[] args){

        Console.WriteLine("Magnitude : " + Pythagoras3D(7,-3, -9));
    }

    // calculating pythagoras length
    public static double Pythagoras(int a, int b){

        int AB = (int) Math.Pow(a, 2);
        int BC = (int) Math.Pow(b, 2);

        double AC = Math.Round(Math.Sqrt(AB + BC), 2);

        return AC;
    }

    public static double Pythagoras3D(double x, double y, double z){
        double result = Math.Round(Math.Sqrt( Math.Pow(x,2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 2);
        return result;
    }

    

  
}