using System.Collections;

class List{

     static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> different;

        different = List.DifferentElements(myList1, myList2);

        foreach (int i in different)
            Console.WriteLine(i);
    }
    public static List<int> DifferentElements(List<int> list1, List<int> list2){
        HashSet<int> HashOne = new HashSet<int>(list1);
        HashSet<int> HashTwo = new HashSet<int>(list2);

        HashOne.SymmetricExceptWith(HashTwo);
        int[] arrInt;
        arrInt = HashOne.ToArray();
        Array.Sort(arrInt);
        HashOne.Clear();
        HashOne.UnionWith(arrInt);

        return new List<int>(HashOne);
    }
}