using System.Collections;
using System;

class List{

     public static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {1, 20, 16, 15, 54};
        List<int> list2 = new List<int>() {1, 0, 2, 3};
        List<int> result;

        result = Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }

    public static List<int> Divide(List<int> list1, List<int> list2, int listLength){
        List<int> result  = new List<int>();
        int TempHold = 0;

        for(int i = 0; i < listLength ; i++){
            try{
                TempHold = list1[i] / list2[i];
                result.Add(TempHold);
            }catch(ArgumentOutOfRangeException){
                Console.WriteLine("Out of range");
            }catch(DivideByZeroException){
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
        }

        return result;
    }
}