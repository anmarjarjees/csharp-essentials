namespace OOP2Modifiers
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
            We can access the public class member
            but it's not recommended, as we discussed this issue in Java:
            it's called "tight coupling" between the Program.cs and Book.cs
            */ 
            book1.Name = "C# Programming"; // bad example!

            book1.SetName("C# Comprehensive");
            Console.WriteLine("The new book name is "+book1.GetName());
        } // main()    
    } // class
} // namespace
