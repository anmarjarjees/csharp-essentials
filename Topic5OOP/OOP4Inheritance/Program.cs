namespace OOP4Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of our class "Book" using the "new" operator:
            // Construct a new object
            Book book1 = new Book("Beginning C# and .NET", "Benjamin Perkins", "Wrox");
            // another object:
            Book book2 = new Book("C# 10.0 All-in-One For Dummies", "John Paul Mueller", "For Dummies", 864, 2022);

            // Calling the method "GetDetails()" through (by using) the two objects:
            System.Console.WriteLine("Book1 Details: \n" + book1.GetDetails());
            System.Console.WriteLine();
            System.Console.WriteLine("Book2 Details: \n" + book2.GetDetails());
            System.Console.WriteLine();

            
            Magazine mag1 = new Magazine("Reader's Digest", "RD Canada", 112, 2022, 6);
            
            /*
            Notice below, we have to be careful! 
            C# will simply assign the argument "2023" to the parameter "pages" as both are integers
            but we had to place any int value for "pages" just to pass "2023" to the "year" parameter:
            */
            Magazine mag2 = new Magazine("Maximum PC", "Future US",0,2023, 3);

            // Calling the method "GetDetails()" through (by using) the two objects:
            System.Console.WriteLine("Magazine1 Details: \n" + mag1.GetDetails()+"\n");
            System.Console.WriteLine("Magazine2 Details: \n" + mag2.GetDetails()+ "\n");

            // Assign an empty name (title) for the book1:
            // book1.Name = "";
            /*
             * It will throw an exception with our custom message that we defined:
             * System.ArgumentException: 'Name value is required'
             */
        } // Main()
    } // class
} // namespace