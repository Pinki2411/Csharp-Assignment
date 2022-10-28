using System;
using System.IO;

namespace Assign7b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Pooja Bannerjee", "Saving Accounts holder", "Rahul Mahajan", "Current Account holder " };
                                                                                         


            using (StreamWriter sw = new StreamWriter("names.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}