using System.Reflection;
using System.Text;


/*
TypeInfo t = typeof(Calendar).GetTypeInfo();
IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
IEnumerable<MethodInfo> mList = t.DeclaredMethods;

StringBuilder sb = new StringBuilder();

sb.Append("Properties:");
foreach (PropertyInfo p in pList)
{

    sb.Append("\n" + p.DeclaringType.Name + ": " + p.Name);
}
sb.Append("\nMethods:");
foreach (MethodInfo m in mList)
{
    sb.Append("\n" + m.DeclaringType.Name + ": " + m.Name);
}

Console.WriteLine(sb.ToString());
*/


class Obj {


    public static void Print(object myObj){

        TypeInfo t =  myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList  = t.DeclaredProperties;
        Console.WriteLine(pList.First().DeclaringType.Name + " Properties:");
 
        StringBuilder sb = new StringBuilder();
        //sb.Append(pList.First().DeclaringType.Name + " Properties:");



        foreach(PropertyInfo p in pList){
            Console.WriteLine(p.Name);
           // sb.Append("\n" + p.Name);
        }

        IEnumerable<MethodInfo> pMethod = t.DeclaredMethods;
           Console.WriteLine(pMethod.First().DeclaringType.Name + " Methods:");
          //sb.Append(pMethod.First().DeclaringType.Name + " Method:");

        foreach(MethodInfo m in pMethod){
            Console.WriteLine(m.Name);
           // sb.Append("\n" + m.Name);
        }

        // Console.WriteLine(sb.ToString());

    }
}

