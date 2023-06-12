using System;
// like import System in Java :-)

namespace Project4Methods // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            double lbValue = 20;
            Console.WriteLine($"Converting {lbValue}lb to kg is: " + PoundToKilo(lbValue));

            /* 
            Notice below, we need to call/execute the methods (functions) by placing the arguments
            according to their parameters:
            - first parameter "name" => has the argument (string value) of "Alex Chow"
            - second parameter "prefix" => has the argument (numeric value) of 1
            */
            PrintName("Alex Chow", 1);

            PrintName("Kate Chow", 2);

            PrintName("Sam Simpson");

            /* 
            We can call the method using "Named Parameters"
            in such case, we can shuffle their order!
            It's a good idea when we have a complex method with too many parameters
            It makes the function easier to read
            */
            PrintName(prefix: 3, name: "Sally Doe");


            // For practicing the "ref" keyword: 
            int myNumber = 10;
            System.Console.WriteLine($"Original Number: {myNumber}"); // Original Number: 10
            // calling our function to square the number:
            /* 
            NOTE: We have to pass the argument using the keyword "ref",
            otherwise, we will see this error in the runtime:
            Argument 1 must be passed with the 'ref' keyword 
            */
            squareIt(ref myNumber);
            System.Console.WriteLine($"squared equals {myNumber}"); // squared equals 100

            // For practicing the "out" keyword: 
            double circ, area;
            double radius = 23.21;
            // We also need to specify the keyword "out" for each out parameter
            findCircumArea(radius, out circ, out area);
            System.Console.WriteLine($"The circle with {radius} radius, the area is {area}, and the circumference is {circ}");

            /* 
            Microsoft added the data type "tuple" that was introduced in C#7 
            tuple can group multiple values.
            The tuples feature provides concise syntax to group multiple data elements in a lightweight data structure.
            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
            
            Examples Below:
            */
            (double, int) t1 = (4.5, 3);
            /* 
            NOTE:
            The default names of tuple fields are Item1, Item2, Item3 and so on. 
            You can always use the default name of a field, 
            even when a field name is specified explicitly or inferred, 
            */
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Tuple with elements 4.5 and 3.

            (double num1, int num2) tup2 = (4.5, 3);
            Console.WriteLine($"The first number of our tuple variable is {tup2.num1}, the second one is {tup2.num2}.");
            // OR the same with using Item1 and Item2:
            Console.WriteLine($"The first number of our tuple variable is {tup2.Item1}, the second one is {tup2.Item2}.");
            // The first number of our tuple variable is 4.5, the second one is 3.

            // another way:
            var tup3 = ("Alex Chow", 58);
            Console.WriteLine($"Full Name: {tup3.Item1}, age: {tup3.Item2}.");
            // Full Name: Alex Chow, age: 58.

            // calling our method getCircumArea that returns tuple:
            (double, double) circleResult = getCircumArea(radius);
            System.Console.WriteLine($"The circle with {radius} radius, the circumference is {circleResult.Item1}, and the area is {circleResult.Item2}");
        } // main()

        
        // Part1: Basic Use of Methods:
        // ****************************
        // Creating our custom function/method:
        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/methods
        /* 
        Pounds to Kilograms formula
        kg =lb/2.2046   
        Link: https://www.metric-conversions.org/weight/pounds-to-kilograms.htm
         */

        // Methods can be either instance or static. 
        // Link: https://learn.microsoft.com/en-us/dotnet/csharp/methods#method-invocation

        static double PoundToKilo(double lb)
        {
            return lb / 2.2046;
        }
        
        /* 
        Functions/Methods with optional parameters:
        Optional arguments:
        ------------------
        The definition of a method, constructor, indexer, or delegate can specify its parameters are required or optional. Any call must provide arguments for all required parameters, but can omit arguments for optional parameters.

        Each optional parameter has a default value as part of its definition. If no argument is sent for that parameter, the default value is used. 

        Optional parameters are defined at the end of the parameter list, after any required parameters.

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        */
        
        /// <param name="name">any text that represents the full name</param>
        /// <param name="prefix">0 (default) for no prefix, 1 for Mr., 2 for MS, 3 for Miss, 4 for Mrs</param>
        static void PrintName(string name, int prefix = 0)
        {
            string pre = "";
            switch (prefix)
            {
                case 1:
                    pre = "Mr.";
                    break;
                case 2:
                    pre = "Ms.";
                    break;
                case 3:
                    pre = "Miss.";
                    break;
                case 4:
                    pre = "Mrs.";
                    break;
            }
            System.Console.WriteLine($"{pre} {name}");
        }

        // Part2: Using "ref" and "out" keywords:
        // **************************************
        /* 
        Passing an argument by reference:
        ---------------------------------
        The "ref' keyword indicates that a variable is a reference, or an alias for another object. It's used in five different contexts:
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

        We know that variables have local scope inside functions/methods, so any change we make into the passing argument or a variable inside a function will not affect the same variable (same name) in the main script "outside the function" because we are passing are a copy of the original value.

        So to pass the original variable to a function, we use the keyword "ref", in such case any change we make into this variable will affect the original one:
        */

        static void squareIt(ref int myNumber)
        {
            // multiply (a number) by itself. 5 squared equals 25
            myNumber *= myNumber;
        }

        /* 
        Declaring out parameters:
        -------------------------
        The "out" keyword causes arguments to be passed by reference. It makes the formal parameter an alias for the argument, which must be a variable. 
        > In other words, any operation on the parameter is made on the argument.
        > It is like the ref keyword, except that ref requires that the variable be initialized before it is passed.
        > It was useful when we want our function/method to return multiple values in older C# coding!
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
        */

        /* 
        Method to calculate the circumference and area of a circle.
        Notice that "out" means that the parameters "circ" and "area"
        will be the returned values of this function NOT passing values
        */
        static void findCircumArea(double r, out double circ, out double area)
        {
            /* 
            The formulas to calculate the circumference and area of a circle:
            Circumference = 2 * PI * radius
            Area = PI * (radius*radius)
            PI => is a constant approximately equal to 3.14159265359
            Link: https://www.omnicalculator.com/math/circumference-area-circle
            */
            circ = 2 * Math.PI * r;
            area = Math.PI * Math.Pow(r, 2);
        }

        /* 
        Using the modern way to let our method returns multiple values
        rewrite our previous method "findCircumArea" but with using "tuple" 
        Notice the method return type is a tuple of two double values:      
        */
        static (double, double) getCircumArea(double r)
        {
            double circum = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);
            return (circum,area);
            // or in one line:
            // return (2 * Math.PI * r, Math.PI * Math.Pow(r, 2));
        }
    } // class
} // namespace