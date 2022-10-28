using System;


namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of integers
            int[] intArray = new int[] { 23, 24, 40, 33, 12 ,50 };
            int[] temp = intArray;
            int[] Clear = intArray;
           // int[] Copy = intArray;
            int[] arrSource = new int[4];
            arrSource[0] = 12;
            arrSource[1] = 13;
            arrSource[2] = 14;
            arrSource[3] = 15;
            int[] arrTarget = new int[4];
               

            Console.WriteLine("Array (Old)");
            foreach( int val in intArray)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Original array");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Sort array in ASC order
            Console.WriteLine("Sorted array in ASCENDING order");
            Array.Sort(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array in DESCENDING order");
            // Sort Array in DESC order
            Array.Reverse(temp);
            Console.WriteLine("Reversed Array ");
            foreach (int i in intArray)
            //foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();


            Array.Clear(intArray, 0, intArray.Length);
               
            Console.WriteLine("Array(After clear):");
            foreach (int val in intArray)
            {
                Console.WriteLine(val);
            }
            Console.ReadKey();

            Array.Copy(arrSource, arrTarget, 4);
            Console.WriteLine("Destination Array   ");
            foreach(int value in arrTarget)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();




            

        }
    }
}
