using System;
using System.Reflection;

public class Assignment8
{
    public static void Main()
    {
     
       
        Assembly a = Assembly.Load("example");
        
        Type myType = a.GetType("Example");
    
        MethodInfo myMethod = myType.GetMethod("MethodA");
        
        object obj = Activator.CreateInstance(myType);
        
        myMethod.Invoke(obj, null);
    }
}