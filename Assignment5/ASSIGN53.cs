using System;
using System.Collections.Generic;
class Example
{
    static void Main()
    {
        string[] empname = { "Mania", "Raj", "Ramya"  , " Yash"};
        string[] total = empname;
        Console.WriteLine("Displaying elements of a Linked List: ");
        LinkedList<string> myList = new LinkedList<string>(empname);
       
        foreach (var res in myList)
        {
            Console.WriteLine(res);
        }
        Console.WriteLine("Total Employess are:");
        foreach ( var sum in myList)
        {

            Console.WriteLine(sum);
        }
        
        
       



    }
}