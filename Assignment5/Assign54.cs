using System;
using System.Collections;

class MyStack
{

    
    static public void Main()
    {


        Stack my_stack = new Stack();

       
        my_stack.Push("Hello");
        my_stack.Push("Goodmorning");
        my_stack.Push("GreatDay");
        my_stack.Push("Hope you doing great");

        Console.WriteLine("Total elements present in" +
                    " my_stack: {0}", my_stack.Count);

        my_stack.Pop();

        
        Console.WriteLine("Total elements present in " +
                      "my_stack: {0}", my_stack.Count);


        
        my_stack.Clear();

        
        Console.WriteLine("Total elements present in " +
                      "my_stack: {0}", my_stack.Count);

    }
}
    
