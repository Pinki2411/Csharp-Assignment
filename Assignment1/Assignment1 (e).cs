using System;

namespace Assign1e
{
    class Program
    {



        static void MyClient()

        {
            Console.Write("Enter Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            double circumference = 2 * Math.PI * rad;
            Console.WriteLine("Area of circle is: " + area);
            Console.WriteLine("Circumference of Circle is :" + circumference);
           
        }
        static void Main(string[] args)
        {
            MyClient();
        }
    }
}
