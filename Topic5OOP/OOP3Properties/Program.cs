namespace OOP3Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of our class "Book" using the "new" operator:
            // Construct a new object
            Book book1 = new Book("Beginning C# and .NET", "Benjamin Perkins", "Wrox");
            // another object:
            Book book2 = new Book("C# 10.0 All-in-One For Dummies", "John Paul Mueller", "For Dummies", 864, 2022);

            // Calling the method "getBookInfo()" through (by using) the two objects:
            System.Console.WriteLine("Book1 Details: \n" + book1.GetBookInfo());
            System.Console.WriteLine();
            System.Console.WriteLine("Book2 Details: \n" + book2.GetBookInfo());

            /* 
            Trying to access the class properties:

            By just typing book1. => the compiler will show us the public method "getBookInfo()"
            The compiler will not show us the class properties/fields as they are internal by default.
            */

            /*
            Now we can access the public public property "Name"
            of the private field "_name" to set/get its value:            
            */ 
            book1.Name = "C# Programming"; 
            Console.WriteLine("The new book name is "+ book1.Name);

            // Practicing the other properties: ISBN and Price:
            book1.ISBN = "200387435122";
            book1.Price = 58.78m; // using "m" with decimal value

            Console.WriteLine($"Book1 ISBN {book1.ISBN} - Price: {book1.Price}");
        } // main()    
    } // class
} // namespace
