﻿
using System;


class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();

        aRect.Width = 7;
        aRect.Height = 4;

        Console.WriteLine("Area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());
    }
}


public class Shape{


/// <summary>
/// Emtpy area calculation
/// </summary>
/// <returns></returns>
/// <exception cref="NotImplementedException"></exception>
    public virtual int Area(){
        throw new NotImplementedException("Area() is not implemented");
    }

}


public class Rectangle : Shape{

    private int width;
    private int height;

/// <summary>
/// managees width
/// </summary>
    public int Width{
        get { return width ;}
        set { 
            if( value < 0){
            throw new ArgumentException("Width must be greater than or equal to 0");
        }
        width = value;
        }
    }

/// <summary>
/// manages height
/// </summary>
    public int Height{

        get { return height;}
        set { if(value < 0){
            throw new ArgumentException("Height must be greater than or equal to 0.");
        }

        height = value;
        }

    }


    public override int Area(){
        return height * width;
    }

    public override string ToString(){

        return $"[Rectangle] {width} / {height}";
    }
}