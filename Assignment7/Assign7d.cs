using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;





//Serialize an Object to Binary
[Serializable]
public class Demo
{
    public string ApplicationName { get; set; } = "Binary Serialize";
    public int ApplicationId { get; set; } = 1001;
}
class Program
{
    static void Main()
    {
        Demo sample = new Demo();
        var fileStream = new FileStream(@"C: \Users\pijush\Example1.txt", FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fileStream, sample);
        Console.ReadKey();
    }
}