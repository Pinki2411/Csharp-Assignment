using System;






namespace Assignment1f
{
    class Program
    {
        struct Books
        {
            public int book_id ;
            public string title;
            public int  price;
            public string bookType;
        };

        enum BookType
        {
            Magazine ,
            Novel ,
            ReferenceBook,
            Miscellaneous   
        }

            public class testStructure
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the details of book:");
                Console.WriteLine("--------------------------------------------------/n");

                var book_id = Convert.ToString(Console.ReadLine());
                Console.WriteLine("The book_id is :");
                string title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("The book title  is :");

                var  price = Convert.ToString(Console.ReadLine());
                Console.WriteLine("The book price  is :");

                 BookType  name  = BookType.Magazine;
                Console.WriteLine(name);


                Console.WriteLine("  Displaying the details of book : /n " 
                    + book_id   + title    + price  );


                
                
            }
        }
    }
}
