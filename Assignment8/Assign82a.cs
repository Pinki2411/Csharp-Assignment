using System;

// AttributeUsage specifies the usage
// of InformationAttribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor |
                        AttributeTargets.Method, AllowMultiple = true)]

// InformationAttribute is a custom attribute class
// that is derived from Attribute class
class InformationAttribute : Attribute
{
    public string InformationString { get; set; }
}

// InformationAttribute is used in student class
[Information(InformationString = "Class")]
public class EmployeeDetails
{

    private string  ProjectName;
    private string Clientname;
    private string Description;
    private string StartedDate;
    private string EndDate;

    [Information(InformationString = "Constructor")]
    public EmployeeDetails(string  pname, string name, string desc,string sdate,string edate)
    {
        this.ProjectName = pname;
        this.Clientname = name;
        this.Description = desc;
        this.StartedDate = sdate;
        this.EndDate = edate;




    }

    [Information(InformationString = "Method")]
    public void display()
    {
        Console.WriteLine("ProjectName: {0}", ProjectName);
        Console.WriteLine("ClientName: {0}", Clientname);
        Console.WriteLine("Description: {0}", Description);
        Console.WriteLine("StartedDate: {0}", StartedDate);
        Console.WriteLine("EndDate: {0}", EndDate);
       



    }
}

// Driver Class
public class SoftwareAttribute
{

    // Main Method
    public static void Main(string[] args)
    {
        EmployeeDetails e = new EmployeeDetails("Web Application", "Lily Adams", "website based application ", "started today "  , "will end on Sunday");
        e.display();
    }
}