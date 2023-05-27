using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
    C# Coding Conventions:
    **********************        

    PascalCase:
    -----------
    Use pascal casing ("PascalCasing") when naming: 
    - class
    - record
    - struct.

    Also with public members of types:
    - fields/properties
    - events, methods, and local functions

    PascalCase with the prefix "I":
    -------------------------------
    When naming an interface, use pascal casing in addition to prefixing the name with an "I".
    This clearly indicates to consumers that it's an interface.
    public interface IWorkerQueue

    camelCase:
    ----------
    use camel casing "camelCase" when writing:
    - method parameters
    - local variables

    camelCase with _:
    -----------------
    Use camel casing ("camelCase") when naming "private" or "internal" fields, 
    and prefix them with _.

    When working with "static" fields that are "private" or "internal", 
    - use the s_ prefix for "static" 
    - use t_ prefix for for "thread static"

    Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions

    Notice that some developers use:
    - "UpperCamelCase" which is simply means "PascalCase"
    - "lowerCamelCase" which is simply means "camelCase"
*/

namespace OOP1ClassIntro // Note: actual namespace depends on the project name.
{
    /* 
    Reference types:
    A type that is defined as a class is a reference type. 
    Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes

    Classes are declared by using the class keyword followed by a unique identifier
    the identifier (class name) must be unique within the same namespace

    The class keyword is preceded by the access level. Because "public" is used in this case, anyone can create instances of this class. 

    Abstraction:
    > As we do in Java/Python, we can add the modifier "abstract" => public abstract Book
    abstract class CANNOT be instantiated CAN ONLY be inherited.
    > Abstract class can have abstract method (a method without a body and can be only declared inside an abstract class only). 
    The full implantation of this method can be done in the derived class
    > An abstract class can have both abstract and regular methods

    NOTE:
    By default, if we don't specify C# will use the most restricted access.
    For example: "internal" for any class and "private" for any field

    Internal types or members are accessible only within files in the same assembly.
    Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal
    Link: https://learn.microsoft.com/en-us/dotnet/standard/assembly/
    */
    public class Book
    {
        // class can have members: properties and methods

        // creating class fields (variables inside the class):
        string _name; // using the prefix "_" for an internal variable name
        string _author;
        string _publisher;
        int _pageCount;
        int _releasedYear;

        /* 
        Using Constructors (C# Programming Guide)
        Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-constructors

        The special function/method "Constructor"
        Adding our custom constructor that will be used to instantiate an object of this class
        Notice we need this constructor to initialize the internal fields of the class

        The publisher parameter has a default value of empty string:
        using =string.Empty (recommended) instead of =""

        IMPORTANT NOTES:
        - This parameter with a default value is called "Optional Parameter"
        - The optional parameters must appear after all the required parameters
        */

        public Book(string name, string author, string publisher = "Unknown")
        {
            _name = name;
            _author = author;
            _publisher = publisher;
        }

        // Class can have multiple constructors:
        public Book(string name, string author, string publisher = "Unknown", int pages = 0, int year = 0)
        {
            _name = name;
            _author = author;
            _publisher = publisher;
            _pageCount = pages;
            _releasedYear = year;
        }

        // Adding other methods:
        // A method to get the full book info => getBookInfo()
        // pressing /// VS IDE will automatically add the XML documentation:

        /// <summary>
        /// Getting the book details
        /// </summary>
        /// <returns>string of details</returns>
        public string GetBookInfo()
        {
            string detailsMsg = _name + " By " + _author;
            detailsMsg += (_pageCount > 0) ? $"\nPage: {_pageCount}" : "";
            detailsMsg += (_releasedYear > 2000) ? $"\nYear: {_releasedYear}" : "";
            detailsMsg += (_publisher != "Unknown") ? $"\nPublisher: {_publisher}" : "\n";

            return detailsMsg;
        }
    } // class
} // namespace
/* 
        You can read more about naming in C# in MS documentation:

        General Naming Conventions:
        Link: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions

        Code-style naming rules:
        Link: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/naming-rules

        > Public methods are PascalCase.
        > Asynchronous methods end with "Async"
        > Constant fields are PascalCase.
        > Non-public static fields are s_camelCase.
        > For classes, structs, enumerations, properties, methods, and events with any accessibility, the default naming style is Pascal case.
        > For interfaces with any accessibility, the default naming style is Pascal case with a required prefix of I.
        > public properties, methods, fields, events, and delegates that are marked readonly must be capitalized. 
        > private instance fields should start with an _; 

        A summarized short articles about C# naming conventions:
        Link: https://www.freecodecamp.org/news/coding-best-practices-in-c-sharp/
        Link: https://www.dofactory.com/csharp-coding-standards
*/
