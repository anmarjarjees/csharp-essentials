using System;

namespace Project2WorkFlow // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// Triple Slashes comments symbol for XML Comments
        /// XML comments are used for code documentation, example below:
        /*  
        <summary> to summarize the method/function
        <param> to describe its parameter if needed
        <returns> to specify the returned value of this method
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
        */

        /// <summary>
        /// this is the Main method which is the entry-point to run/launch our application
        /// </summary>
        /// <param name='args'>Array of string elements that are the console arguments in the command line
        /// <returns>
        /// Void: No return value
        /// </returns>
        static void Main(string[] args)
        {
            /* 
            Like in many other languages, two ways to apply conditions:
            - if statement
            - switch statement
            */

            // Part1: if statement
            // *******************
            double avg = 50;
            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators
            if (avg >= 80)
            {
                // type cw then tab...
                // NOTE: No need for "System" as it's already in use (using/imported)
                System.Console.WriteLine("Well Done!");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("Never give up! You can try again");
            }

            /* 
            Converting a simple if statement to ternary operator:
            */
            if (avg >= 50)
            {
                Console.WriteLine("You passed the course!");
            }
            else
            {
                Console.WriteLine("Never give up! You can try again");
            }

            System.Console.WriteLine(avg >= 50 ? "You passed the course!" : "You can try again");

            // Part2: switch statement
            // ***********************
            // Link:https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement
            switch (avg)
            {
                /*   the value that we are using a double value for the average
                     it could be string, int...
                     it's better to use if statement when we have range of numbers!
                     because we can go beyond 100 and less than 0! */
                case < 50:
                    Console.WriteLine($"Your average {avg}; too low.");
                    break;

                case > 80.0:
                    Console.WriteLine($"Your average {avg}; too high.");
                    break;

                case > 70:
                    Console.WriteLine($"Your average {avg}; good.");
                    break;

                case >= 60:
                    Console.WriteLine($"Your average {avg}; Not bad.");
                    break;

                case >= 50:
                    Console.WriteLine($"Your average {avg}; Just Passing.");
                    break;

                default:
                    Console.WriteLine($"Invalid {avg} value!");
                    break;
            }

            /* 
            like in other langues:
            we can combine multiple case statements:
            case 10:
            case 11:
            case 12:
                ... you code...
                break;
             */


            // Part2: Iteration
            // ****************
            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
            /* 
            prefix or postfix increment expression, such as ++i or i++
            prefix or postfix decrement expression, such as --i or i--
            */

            // The for statement:
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            // Output:
            // 0123456789

            // All the sections of the for statement are optional.
            // For example, the following code defines the infinite for loop:
            /*
            for (; ; )
            {
                //...
            }
            */

            Console.WriteLine();
            string[] languages = { "Java", "PHP", "JavaScript", "C#" };
            for (int i = 0; i < languages.Length; i++)
            {
                System.Console.WriteLine(languages[i]);
            }

            // The foreach statement
            foreach (string language in languages)
            {
                Console.Write($"{language} ");
            }

            Console.WriteLine();
            var oddNumbers = new List<int> { 1, 3, 5, 7, 9 };
            foreach (int element in oddNumbers)
            {
                // write them all in one line:
                Console.Write($"{element} ");
            }
            // Output:
            // 0 1 1 2 3 5 8 13

            /* 
            Task: count the words "C#" in this paragraph
            */
            string myParagraph = "C# is one the most popular language. It's the main language for DOT Net. Learning C# before ASP.NET is recommended. C# is not only one language for .NET framework, there are Fsharp and VB also.";

            // count the number of "C#" in the string
            /* 
            NOTE: 
            1.looping through the string means looping for each character
            So we cannot use "C#" we can just pick its symbol :-)
            Also we had to write F# as Fsharp so it will not be counted!
            
            2. Also we have to use '' with character NOT ""
            */
            var count = 0;
            foreach (char character in myParagraph)
            {
                if (character == '#')
                {
                    count++;
                }
            }

            Console.WriteLine("\nThe word \"C#\" appeared {0} time(s) in the paragraph", count);


            // The do statement
            int n = 0;
            do
            {
                Console.Write(n);
                n++;
            } while (n < 5);
            // Output:
            // 01234

            // The while statement
            n = 0;
            while (n < 5)
            {
                Console.Write(n);
                n++;
            }
            // Output:
            // 01234

            Console.WriteLine("While loop:");
            string inputStr = "";
            while (inputStr.ToLower() != "n")
            {
                Console.WriteLine("Enter your text:");
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
                Console.WriteLine("Do you want to continue? Enter N/n for No or just press Enter to continue:");
                inputStr = Console.ReadLine();
            }

            // We can repeat the same example with do while...

            // Part2: break and continue
            // *************************
            /* 
            At any point within the body of an iteration statement, you can break out of the loop using the break statement. You can step to the next iteration in the loop using the continue statement.
            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements#the-break-statement

            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements#the-continue-statement
            */

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Iteration {i}: ");

                if (i < 3)
                {
                    Console.WriteLine("skip");
                    continue;
                }

                Console.WriteLine("done");
            }
            // Output:
            // Iteration 0: skip
            // Iteration 1: skip
            // Iteration 2: skip
            // Iteration 3: done
            // Iteration 4: done


            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int number in numbers)
            {
                if (number == 3)
                {
                    break;
                }

                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine("End of the example.");
            // Output:
            // 0 1 2 
            // End of the example.

            // Part4: Exceptions and Exception Handling
            // ****************************************
            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
            /* 
            Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
            */
            int n1 = 30;
            int n2 = 0;
            int result;

            try
            {
                result = n1 / n2;
                Console.WriteLine("The result is: {0}", result);
            }
            /* 
            When n2 (the denominator) is 0, we will receive this error:
            Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            
            Define the catch block:
            It's a generic catch handler we didn't specify the exception class name:
            */
            catch
            {
                Console.WriteLine("Something went wrong!");
            }

            // As we do with Java, we can specify the exception that we want to catch:
            // we will repeat the same block:
            try
            {
                result = n1 / n2;
                Console.WriteLine("The result is: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                // using the property "Message" for the object "e"
                Console.WriteLine("Error! " + e.Message);
                // Error! Attempted to divide by zero.
            }
            /* 
            NOTE:
            Notice if you dig deep to trace the root of the exception "DivideByZeroException":
            1. DivideByZeroException
            2. extends ArithmeticException
            3. extends SystemException
            4. extends Exception

            So Exceptions are represented by classes derived from "Exception" class
            */


            /* 
                So we can use the general Exception class to catch any exception

                Example we can throw an exception if one the input contains string value!
                let's create new variables for this demo:
            */
            try
            {
                System.Console.WriteLine("Enter your first integer (whole) number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter your second integer (whole) number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                /* 
                Learn more from MS Documentation:
                Link: https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-7.0
                Link: https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint32?view=net-7.0

                A summarized short article from FreeCodeCamp:
                Link: https://www.freecodecamp.org/news/how-to-convert-a-string-to-an-integer-in-c-sharp/
                */

                /* 
                If we input a string value instead of integer
                Unhandled exception. System.FormatException: Input string was not in a correct format.
                */
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
                // Error! Input string was not in a correct format.

                // Using the method .GetType() to get the type of the exception:
                Console.WriteLine("Exception Class Name: " + e.GetType());
                // Exception Class Name: System.FormatException                
            }


            /* 
            - try { } block can have multiple catch { } blocks
            - also we can trigger (throw) an exception using the "throw" statement
             */
            try
            {
                System.Console.WriteLine("Enter your first integer (whole) number between 0  and 10: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter your second integer (whole) number between 0  and 10: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    // Try this:
                    System.Console.WriteLine("Both numbers must be between 0 and 10!");

                    // then this:
                    // throw new Exception();
                    // throw new ArgumentOutOfRangeException("Both numbers must be between 0 and 10!");

                    throw new ArgumentOutOfRangeException("number1 and number2 cannot be less than 0 or beyond 10!");
                    //  (Parameter 'number1 and number2 cannot be less than 0 or beyond 10!')
                }

                // using the same global variable "result"
                result = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
                // Error! Specified argument was out of the range of valid values.

                // Using the method .GetType() to get the type of the exception:
                Console.WriteLine("Exception Class Name: " + e.GetType());
                // Exception Class Name: System.ArgumentOutOfRangeException              
            }
            // exception can have finally block:
            finally
            {
                System.Console.WriteLine("This code is always going to run whether to have or doesn't have an exception");
            }


            // Final Example :-)
            System.Console.WriteLine("******************");
            System.Console.WriteLine("One More Practice:");
            System.Console.WriteLine("*******************");
            try {
                System.Console.WriteLine("Enter an integer numeric value between 0  and 10: ");
                int value1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter another integer numeric value between 0  and 10: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                if (value1 < 0 || value1 > 10 || value2 < 0 || value2 > 10)
                {
                    throw new ArgumentOutOfRangeException("value1 and value2 cannot be less than 0 or more than 10!");
                    //  (Parameter 'value1 and value2 cannot be less than 0 or beyond 10!')
                }

                // using the same global variable "result"
                result = value1 / value2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
                // Error! Attempted to divide by zero.
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Your input is out of range!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This finally block code will always run.");
            }
        } // main()
    } // class    
} // namespace
