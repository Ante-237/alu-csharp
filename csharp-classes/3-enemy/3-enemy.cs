﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

namespace Enemies{
   
    /// <summary>
    /// Zombie is a public class 
    /// </summary>
    public class Zombie{

        // local health variable
        int health;


        /// <summary>
        /// Zombie Constructor inits health to zero
        /// </summary>
        public Zombie(){
            health = 0;
        }


        /// <summary>
        /// Zoombie Constructor inits only for int greater than or equal to zero
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public Zombie(int value){
            if( value < 0){
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }

        /// <summary>
        /// Method returns health local variable
        /// </summary>
        /// <returns>health</returns>
        public int GetHealth(){
            return health;
        }



    }
}
