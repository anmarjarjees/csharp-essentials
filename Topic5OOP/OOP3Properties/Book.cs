
namespace OOP3Properties // Note: actual namespace depends on the project name.
{
    public class Book
    {
        /*
        Using Properties in C#: it's like a combination of variables and methods
        
        So property in C# is using the member field in the form of a method with getter and setters
         */

        // make all the fields private (recommended) or protected but NOT public!
        private string _name;
        /*
         * NOTE: You can also right click the field _name:
         * - Quick Action and Refactoring
         * - Encapsulate Field: ...
         * 
         * To be covered in the next topics :-)
        */

        // protected => to be accessed inside the class or its derived class
        private string _author;

        // private => to be accessed within the class itself
        private string _publisher;
        private int _pageCount;
        private int _releasedYear;

        /// <summary>
        /// Getting the book details
        /// </summary>
        /// <returns>string of details</returns>
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

        /*
         * Using the C# public properties to access the class fields:
        */
        public string Name
        {
            // Adding the getters and setters:
            get
            {
                return _name;
            } 
            
            set
            {
                // using the keyword "value"
                _name= value;
            }
        }

        /*
         * Using the same with Author but with different syntax:
        */
        public string Author
        {
            get => _author; // just return the _author
            set => _author = value; // set a value to the _author
        }

        public string Publisher
        {
            get =>  _publisher;
            // We can remove the "set" statement and this will make this property for Reading Only
            // set => _publisher = value;
        }

        public int PageCount
        {
            get => _pageCount; set => _pageCount = value;
        }

        // and so on for the rest of the class fields...

        // Adding other methods:
        // A method to get the full book info => getBookInfo()
        /* 
         * Now we can modify our original method to use the class properties
         * to access the class fields!
         */

        public string GetBookInfo()
        {
            string detailsMsg = Name + " By " + Author;
            detailsMsg += (PageCount > 0) ? $"\nPage: {PageCount}" : "";

            // Notice that we haven't created properties for this field: _releasedYear
            detailsMsg += (_releasedYear > 2000) ? $"\nYear: {_releasedYear}" : "";
            detailsMsg += (Publisher != "Unknown") ? $"\nPublisher: {Publisher}" : "\n";

            return detailsMsg;
        }

        /*
         Finally: Using auto-generated properties.
         A type of properties that don't have class fields
         they are all in one (a class field and a property at the same time)

         In other words, they hold the data beside controlling their access
         */
        public string ISBN
        {
            get;
            set;
        } = string.Empty;
        /*
         * IMPROTNAT WARNING NOT:
         * **********************
         * Why adding: = string.Empty;
         * Comment this statement and check/read the warning message for Book constructor
         * Because of this warning "Nonnullable reference not initialized"
         * This set of warnings alerts you that you're assigning a variable 
         * whose type is non-nullable to an expression whose null-state is maybe-null. 
         * These warnings are:
         * CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. 
         * Consider declaring it as nullable.
         * CS8762 - Parameter must have a non-null value when exiting.
         * 
         * The simple solution in our case:
         * Since we are creating a "Book" object before setting its "ISBN" property of "string" data type,
         * we can initialize the properties using a default non-null value:
         * 
         * Read more:
         * Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings?f1url=%3FappId%3Droslyn%26k%3Dk(CS8618)#nonnullable-reference-not-initialized
         * 
         * If you want to disable this warning, You can:
         * 1. double click the "project name" in the sln window
         * 2. Modify the project XML code by changing "enable" 
         * of "<Nullable>enable</Nullable>" to "disable"
         * you can check this:
         * Link: https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references#nullable-contexts
         */

        public decimal Price
        {
            get;
            set;
        }


        /*
         You can see in the two examples above:
        - there are no private class fields for "ISBN" and "Price"
        - These two properties are not associated with any class field,
        they just hold the data directly
         */
    } // class
} // namespace