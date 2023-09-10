using System.Collections.Generic;

class LList{
    public static int Pop(LinkedList<int> myList){
        if(myList.Count == 0){
            return 0;
        }else{
            return myList.First.Value;
        }
    }
}