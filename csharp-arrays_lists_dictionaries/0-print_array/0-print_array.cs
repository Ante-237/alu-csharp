using System.Collections;


        int[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);



class Array{

    public static int[] CreatePrint(int size){

        if(size == 0){
            Console.WriteLine();
            return new int[0];
        }else if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] NumberList = new int[size];
        for(int i = 0; i < size; i ++){
            NumberList[i] = i;
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        return NumberList;
    }
}