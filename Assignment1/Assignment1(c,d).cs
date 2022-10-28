using System;

namespace Assignment1cd
{
    class Program
    {
        public static int Sum(int[] arr)
        {
            int tot = 0;
            for (int i = 0; i < arr.Length; i++)
                tot += arr[i];
            return tot;
        }



        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.Write("\n Calculate the sum of the elements in an array :\n");


            Console.Write("Enter  5 elements in the array :\n");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("element - {0} : ", j);
                arr[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is {0}", Sum(arr));



            int index = 0;


            int temp = 0;


            int[] arr1 = new int[5];
            int[] arr2 = new int[5];


            Console.WriteLine("Enter value of array1 elements...");
            for (index = 0; index < arr1.Length; index++)
            {
                Console.Write("Element arr1[" + (index + 1) + "]: ");
                arr1[index] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Enter value of array2 elements...");
            for (index = 0; index < arr2.Length; index++)
            {
                Console.Write("Element arr2[" + (index + 1) + "]: ");
                arr2[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\nBefore Swapping...");
            Console.WriteLine("Array 1 Elements\n");
            for (index = 0; index < 5; index++)
            {
                Console.Write(arr1[index] + " ");
            }
            Console.WriteLine("\nArray 2 Elements\n");
            for (index = 0; index < 5; index++)
            {
                Console.Write(arr2[index] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            for (index = 0; index < 5; index++)
            {
                temp = arr1[index];
                arr1[index] = arr2[index];
                arr2[index] = temp;

            }

            Console.WriteLine("\n\nAfter Swapping...");
            Console.WriteLine("Array 1 Elements\n");
            for (index = 0; index < 5; index++)
            {
                Console.Write(arr1[index] + " ");
            }
            Console.WriteLine("\nArray 2 Elements\n");
            for (index = 0; index < 5; index++)
            {
                Console.Write(arr2[index] + " ");
            }

            Console.WriteLine();

        }
    }
}
