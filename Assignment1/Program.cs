using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Assignment  for calculator.
           
            Console.WriteLine("Enter two Number for the operation!");
            int  num1 = Convert.ToInt32(Console.ReadLine());
            int  num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Addition of two numbers "    +  (num1 + num2));
            Console.WriteLine("Subtraction  of two numbers  "    +  (num1 - num2));
            Console.WriteLine("Multiplication of two numbers  "    + num1 * num2);
            Console.WriteLine("Division of two numbers  "    + num1 / num2);

            //Accept Average Marks Assignment.

            Console.WriteLine("Enter Five Students Marks");
            int Marks1 = Convert.ToInt32(Console.ReadLine());
            int Marks2 = Convert.ToInt32(Console.ReadLine());
            int Marks3 = Convert.ToInt32(Console.ReadLine());
            int Marks4 = Convert.ToInt32(Console.ReadLine());
            int Marks5 = Convert.ToInt32(Console.ReadLine());

            var result = Marks1 + Marks2 + Marks3 + Marks4 + Marks5 / 5;
            Console.WriteLine("Average Marks for student   " + result);

          
            int max;
            if (Marks1 > Marks2 && Marks1 > Marks3 && Marks1 > Marks4 && Marks1 > Marks5)
            {
                max = Marks1;
                Console.WriteLine("The highest Marks is:" + (max));
            }
            else if (Marks2 > Marks1 && Marks2 > Marks3 && Marks2 > Marks4 && Marks2 > Marks5)
            {
                max = Marks2;
                Console.WriteLine("The highest Marks is: " + (max));
            }
            else if (Marks3 > Marks1 && Marks3 > Marks2 && Marks3 > Marks4 && Marks3 > Marks5)
            {
                max = Marks3;
                Console.WriteLine("The highest Mark is:  " + (max));
            }
            else if (Marks4 > Marks1 && Marks4 > Marks2 && Marks4 > Marks3 && Marks4 > Marks5)
            {
                max = Marks4;
                Console.WriteLine("The highest Marks is:"+ (max));
            }
            else
            {
                max = Marks5;
                Console.WriteLine("The highest Marks is:" +(max));
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
