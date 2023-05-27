/* 
    With C# version 9 and after, we can use the top-level statement!
*/
// See https://aka.ms/new-console-template for more information

/*
Program.cs is the main program to run our main application
as it's contain the main method()
*/

/* 
The default template:
---------------------
See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
*/

// See https://aka.ms/new-console-template for more information
/*
 With C#9 => MS added the "top level statement" 
*/

/* 
As we use the "import" keyword to import packages in java,
we use the "using" keyword to use (import) a namespace (package) called "System"

You can think of "namespace" in C# is like "package" in Java

the class "System" is consisted on many classes and methods

We will be using some of the code from .NET System namespace (class)
 */
using System; // Unnecessary using directive.
// after using System => we can just run Console.WriteLine() instead of System.Console.WriteLine().

/*
 * namespace is used to encapsulate our variables and avoid conflict 
 * with any other variable in .NET Framework itself or from third-party libraries that we might use
 * 
 * "System" is a namespace and "Console" is a class in that namespace. 
 * Using PascalCase with C#
 */

namespace Project1Intro // Note: actual namespace depends on the project name.
{
    /*
    Our code in C# is organized into classes like in Java 
    Now we can specify the access modifier "Public", we will cover them in more details later
    internal is the default if no access modifier is specified.
     
    Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

    Link: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/program-building-blocks#accessibility
    */
    class Program
    {
        /*
        Main() is the entry point to run our application 
        void => doesn't return any value
        accepts array of string => string[] args
        it contains the command line arguments for our apps when it starts
        */
        static void Main(string[] args)
        {
            // Part1: Intro
            // ************
            /* 
            The Console object that we are using in our code below
            is coming from the "System" class 
            we import "System" class => using System

            Console Object:
             > represents the terminal window
             > it's contained within the "System" namespace "class"
             > it contains the method "WriteLine()"
            */
            Console.WriteLine("Hello, World!");
            // adding a ReadLine() to wait for the user to press enter key

            /* 
            Reads the next line of characters from the standard input stream.
            Returns:
            The next line of characters from the input stream, 
            or null if no more lines are available.
             */
            Console.ReadLine(); // will stop the runtime

            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null

            // adding more code:
            Console.WriteLine("Enter your subject:");
            // string subject = Console.ReadLine(); // reading a line of text
            /* 
            Converting null literal or possible null value to non-nullable type
            The compiler emits these warnings when you attempt to assign an expression that is maybe-null to a variable that is nonnullable. 
            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference

            in other words, C# is complaining in case if the user didn't put any text
            and just press enter to return a null value which cannot be assigned to C#!
            */
            string subject;
            /* 
            The ?? operator is the null-coalescing operator:
            This ?? operator (discussed in details at the end of this file)
            The other actions instruct the compiler that the right-hand-side of the assignment is not-null. 
            The expression on the right-hand-side could be null-checked before assignment, 
            as shown in the following example:

            string myStr1 = null;
            string myStr2 = myStr1 ?? "Nothing" // myStr2 will have the value of "Nothing"
             */
            subject = Console.ReadLine() ?? ""; // reading a line of text

            /* 
            Printing and testing the values:
            We can also use the + for concatenation as with Java and JavaScript:
            */
            Console.WriteLine("Your current subject is " + subject);

            // adding more code:
            Console.WriteLine("Enter your college name:");
            string college = Console.ReadLine();
            Console.WriteLine("Your current college is " + college);
            // We can also read user input as integer https://www.w3schools.com/cs/cs_user_input.php

            // Or using the template $ with {}:
            Console.WriteLine($"Your studying in {college} college");

            /* 
            IMPORTANT NOTE: 
            Every Project folder in C# must contain one class that has the main() method
            as an entry point to run the application, otherwise this error will occur:

            error CS0017: Program has more than one entry point defined. 
            Compile with /main to specify the type that contains the entry point. 
            */



            // Part2: Data Types
            // *****************
            // Basic Data Types:
            int intNum = 100;
            double doubleNum = 100.00;
            float floatNum = 7.0f; // ends with "f"
            decimal decNum = 23.7m; // ends with "m"
            bool boolVar = true; // false
            char charVar = 'A'; // using ' '

            // declaring a string which is a list/collection of characters 
            string str = "C# Programming Language"; // like in Java, we cannot use ' '

            // Declaring implicit variables using the keyword "var"
            // the compiler will figure it out based on the variable value
            var x = 10;
            var y = "Hello!";
            var z = false;

            // arrays: list of values
            // Declaring and array of 7 integer values
            int[] numbers = new int[7];

            // Declaring and initializing array of 4 string values
            string[] languages = { "Java", "PHP", "JavaScript", "C#" };

            // we can also use "Formatting String":
            // {0} => placeholder for first index 0
            /*
            IMPORTANT NOTE:
            - The index numbers must match the number of the corresponding variables  
            - The sequence must be correct without skipping any number: 0, 1, 2, 3, 4,....
            */
            Console.WriteLine("Integer: {0} - Double: {1} - Float: {2} -  Decimal: {3}",
            intNum, doubleNum, floatNum, decNum);

            /*  
            "null" value 
            - means "no value"
            - Using the value of "null" with variable of type "object" or "string":

            As with Java "Object" class is the mother of all the classes,
            in C# also "Object" class is the base class of all the classes,
            we can refer to it with "Object" or "object"
            */
            object obj = null;
            Console.WriteLine("The object value: " + obj);

            /*
             * We can convert between different types of data types
             */
            // Implicit conversion between types data types
            long longNum; // a very large integer value/number
                          // below longNum as long Integer became an integer (Implicit Conversion)
            longNum = 20; // implicitly converted

            // Another example with float
            // we can use (float), (double) also
            float minimum = intNum;
            Console.WriteLine("The minimum value is: {0}", minimum);


            // Explicit conversions
            // Error: cannot implicitly convert type 'double' to 'int'
            // int maximum = doubleNum;

            // we need to cast 
            int maximum = (int)doubleNum;
            Console.WriteLine("The maximum value is: {0}", maximum);


            // now we can also us explicit conversion with float as shown below:
            int intValue = 10;
            float myFloatVar = (float)intValue;
            Console.WriteLine("1. Our new Float Value is: {0}", myFloatVar);
            // But no need! You can just use:
            myFloatVar = intValue;
            Console.WriteLine("2. Our new Float Value is: {0}", myFloatVar);

            /* 
            Default values of C# types (C# reference):
            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values
            */


            // Part3: Operators
            // ****************
            // Declare and initialize two integer variables and string variables together:
            int num1 = 20, num2 = 30;
            string letters1 = "CDE", letters2 = "FGAB";

            /* 
            Basic Math Operations:
            PEDAMS (BEDMAS): () => Exponent => / => * => + => -
            */
            Console.WriteLine("----- Addition and Concatenation -----");
            Console.WriteLine("Average of {0} and {1} is {2}", num1, num2, (num1 + num2) / 2);
            Console.WriteLine("Music Notes: " + letters1 + letters2);

            // Increment / decrement operators
            Console.WriteLine("----- Increment and Decrement -----");
            num1++; // Increment => Add 1 => 20 + 1 = 21
            num2--; // Decrement => Subtract 1 => 30 - 1 = 29
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            /*  
            We can summarize/shorten the full Operator Formulas: 
            total = total + number
            total += number
            */

            // adding num1 and num2 then save the result to num1
            num1 += num2; // 21 + 29
            Console.WriteLine(num1); // 50

            /*  
            Logical operators:
            - AND => &&
            - OR => ||

            Link:https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
            */
            Console.WriteLine("----- Logic Operators: && and || -----");
            // reset the values for num1 and num2:
            num1 = 20; num2 = 30;
            Console.WriteLine(num2 > num1 && num2 >= 30); // True AND False = False
            Console.WriteLine(num1 > num2 || num2 >= 20); // True OR True = True

            /* 
            Double-question mark operator => ??
            the ?? operator uses left operand if not null, or right one if it is
            */
            string testStr = null;
            /* 
            The code below has this expression: 
            testStr ?? "I am available :-)"

            null OR "I am available :-)" => null will be ignored => "I am available" will be returned:
            */
            Console.WriteLine(testStr ?? "I am available :-)");
        } // Main()
    } // class
} // namespace



