using System.Collections;

class List{

static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(16);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(1);
        Console.WriteLine("List Length: " + newList.Count);        
    }

    public static List<int> CreatePrint(int size){
        
        if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }else{
            List<int> CacheList = new List<int>();
            for(int i = 0; i < size ; i ++){
                Console.Write(i + " ");
                CacheList.Add(i);
            }
            Console.WriteLine();
            return CacheList;
        }
    }
}