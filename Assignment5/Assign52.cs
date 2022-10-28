using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("Nandini");
            a1.Add(1200);
            ArrayList a2= new ArrayList();
            a2.Add(2);
            a2.Add("Suresh");
            a2.Add(1700);
            ArrayList a3 = new ArrayList();
            a3.Add(3);
            a3.Add("Maya");
            a3.Add(1300);
            ArrayList a4 = new ArrayList();
            a4.Add(4);
            a4.Add("Chini");
            a4.Add(5000);







            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.ReadKey();
            Console.WriteLine(a2[0]);
            Console.WriteLine(a2[1]);
            Console.WriteLine(a2[2]);
            Console.ReadKey();
            Console.WriteLine(a3[0]);
            Console.WriteLine(a3[1]);
            Console.WriteLine(a3[2]);
            Console.ReadKey();
            Console.WriteLine(a4[0]);
            Console.WriteLine(a4[1]);
            Console.WriteLine(a4[2]);
            Console.ReadKey();









        }

    }
}