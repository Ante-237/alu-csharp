using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}

namespace Enemies{
    /// <summary>
    ///  zombie is an empty class
    /// </summary>

    public class Zombie{

    }
}

