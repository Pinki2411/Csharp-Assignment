using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            // array initialization
            int[] arr = new int[3];
            // finding length
            int arrLength = arr.Length;
            Console.WriteLine("Length of the array: " + arrLength);
            int[] arraytobecloned = { 12, 24, 56, 87 };
            int[] clonedarray = arraytobecloned.Clone() as int[];   //cloning array
                                                                    // display original and cloned arrays
            Console.WriteLine(string.Join("    Original array              ", arraytobecloned));
            Console.WriteLine(string.Join("   Cloned array", clonedarray));
            Console.WriteLine();
            Console.ReadLine();
        }






        
        }
    }

