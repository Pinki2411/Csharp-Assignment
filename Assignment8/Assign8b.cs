using System;
using System.Reflection;
using System.Collections.Generic;


class NewAttribute : Attribute
{

    
    private string title;
    private string description;

    
    public NewAttribute(string t, string d)
    {
        title = t;
        description = d;
    }

   
    public static void AttributeDisplay(Type classType)
    {
        Console.WriteLine("Methods of class {0}", classType.Name);

        

        MethodInfo[] methods = classType.GetMethods();

        

        for (int i = 0; i < methods.GetLength(0); i++)
        {

            

            object[] attributesArray = methods[i].GetCustomAttributes(true);

          
            foreach (Attribute item in attributesArray)
            {
                if (item is NewAttribute)
                {

                    
                    NewAttribute attributeObject = (NewAttribute)item;
                    Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
                     attributeObject.title, attributeObject.description);
                }
            }
        }
    }
}

// Class Employer
class HDFCAccount
{

    // Fields of Employer
    int id;
    string name;

    // Constructor
    public HDFCAccount(int i, string n)
    {
        id = i;
        name = n;
    }

    // Applying the custom attribute 
    // NewAttribute to the getId method
    [NewAttribute("Accessor", "Gives value of Employer Id")]
    public int getId()
    {
        return id;
    }

    // Applying the custom attribute 
    // NewAttribute to the getName method
    [NewAttribute("Accessor", "Gives value of Employer Name")]
    public string getName()
    {
        return name;
    }
}

// Class Employee
class ICICIAccount
{

    // Fields of Employee
    int id;
    string name;

    public ICICIAccount(int i, string n)
    {
        id = i;
        name = n;
    }

    
    [NewAttribute("Accessor", "Gives value of Employee Id")]
    public int getId()
    {
        return id;
    }

    
    [NewAttribute("Accessor", "Gives value of Employee Name")]
    public string getName()
    {
        return name;
    }
}

class Program
{

    static void Main(string[] args)
    {

       
        NewAttribute.AttributeDisplay(typeof(HDFCAccount));

        Console.WriteLine();

        NewAttribute.AttributeDisplay(typeof(ICICIAccount));
    }
}