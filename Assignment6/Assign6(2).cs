using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
delegate void MDelegate();
class DM
{
    static public void Display()
    {
        Console.WriteLine("Kilometer travel");
    }
    static public void print()
    {
        Console.WriteLine("Tour Allowence");
    }
    static public void post()
    {
        Console.WriteLine("Telephone allowence");
    }




}
class MTest
{
    public static void Main()
    {
        MDelegate m1 = new MDelegate(DM.Display);
        MDelegate m2 = new MDelegate(DM.print);
        MDelegate m3 = new MDelegate(DM.post);
        MDelegate m4 = m1 + m2 +m3;
        MDelegate m5 = m2 + m1 + m4;
        MDelegate m6 = m3 - m2;
        m4();
        m5();
        m5();
    }
}