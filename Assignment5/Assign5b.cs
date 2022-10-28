using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "Pinky", "Pijush", "Tina", "Rahul", "Nandini" };
            string[] Clear = strArray;

            Console.WriteLine("Before clearing ");
            foreach  ( string val in strArray)
            {
                Console.WriteLine(val);
            }


            Console.WriteLine();
            Console.WriteLine("Original array");
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
           
            Array.Sort(strArray);
           
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Array.Reverse(strArray);
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();


            Array.Clear(strArray,0,strArray.Length);
            foreach (string str in strArray)
                Console.WriteLine();
            {
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
