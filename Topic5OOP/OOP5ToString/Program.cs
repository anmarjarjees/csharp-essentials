namespace OOP5ToString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Using ToString() method with the basic data types:");
            int intNum = 100;
            double doubleNum = 100.00;
            float floatNum = 7.0f; // ends with "f"
            decimal decNum = 23.7m; // ends with "m"
            bool boolVar = true; // false
            char charVar = 'A'; // using ' '

            Console.WriteLine("intNum: "+ intNum.ToString());
            Console.WriteLine("doubleNum: " + doubleNum.ToString());
            Console.WriteLine("floatNum: " + floatNum.ToString());
            Console.WriteLine("decNum: " + decNum.ToString());
            Console.WriteLine("boolVar: " + boolVar.ToString());
            Console.WriteLine("charVar: " + charVar.ToString());


            Console.WriteLine("Using ToString() method with objects:");
            /*
            Simple example using the C# base class "Object"
            By default, the ToString() method prints:
            - the namespace
            - the class name
            */
            Object obj1 = new Object();
            Console.WriteLine("obj1: "+ obj1.ToString()); // Output: obj1: System.Object

            /*
            Notice that in C# using Object or object is the same
            both refer to the base class "Object"
            */
            object obj2 = new object();
            Console.WriteLine("obj2: " + obj2.ToString()); // Output: obj2: System.Object

            // try it with our Book class:
            Book book1 = new Book("I don't know why?","Alex Chow", "Galaxy");
            Console.WriteLine("\nbook1: " + book1.ToString());
            // Output without (before) overriding: book1: OOP5ToString.Book

            Console.WriteLine("\n\nbook1: " + book1);

            Console.WriteLine("\n*******************\n");
            /*
            NOTE: 
            This method will be called when the object is implicitly converted to a string
            even we don't write it, Console.WriteLine will call it (implicit conversion)
             */
            Book book2 = new Book("I know why? But I will not tell you!", "Sam Simpson", "Galaxy",985,2020);
            
            Console.WriteLine("\n\nbook2: ");
            // Calling the ToString() overloaded method:
            Console.WriteLine("\nbook2 with ToString(1):\n" + book2.ToString(1));
            Console.WriteLine("\nbook2 with ToString(2):\n" + book2.ToString(2));
            Console.WriteLine("\nbook2 with ToString(3):\n" + book2.ToString(3));
        } // Main()
    } // class
} // namespace