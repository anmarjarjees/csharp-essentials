
namespace OOP2Modifiers // Note: actual namespace depends on the project name.
{
    public class Book
    {

        /*
        class can have members: fields/properties and methods

        In C# fields and properties have different meaning/use:
        - fields are just the variables that we declare within our class
        - properties are the functions to be applied on each field for getting/setting their values
        */
        // 

        // creating class fields (variables inside the class):
        /*
         * For learning and demonstration: make this field public 
         * (public field => against the idea of encapsulation!)
         * 
         * PascalCase for:
         *  - class
            - record
            - struct.
            - public fields 
            - Properties (for getters and setters) and Methods
        */
        public string Name; // Public class field => Name
        /*
         * NOTE: You can also right click the field name:
         * - Quick Action and Refactoring
         * - Encapsulate Field: ...
         * 
         * To be covered in the next topics :-)
        */

        // protected => to be accessed inside the class or its derived class
        protected string Author; // Public class field => Author

        // private => to be accessed within the class itself
        private string _publisher; // Private class field => _publisher
        private int _pageCount;
        private int _releasedYear;

        /// <summary>
        /// Getting the book details
        /// </summary>
        /// <returns>string of details</returns>
        public Book(string name, string author, string publisher = "Unknown")
        {
            Name = name;
            Author = author;
            _publisher = publisher;
        }

        // Class can have multiple constructors:
        public Book(string name, string author, string publisher = "Unknown", int pages = 0, int year = 0)
        {
            Name = name;
            Author = author;
            _publisher = publisher;
            _pageCount = pages;
            _releasedYear = year;
        }

        // Adding other methods:
        // A method to get the full book info => getBookInfo()
        public string GetBookInfo()
        {
            string detailsMsg = Name + " By " + Author;
            detailsMsg += (_pageCount > 0) ? $"\nPage: {_pageCount}" : "";
            detailsMsg += (_releasedYear > 2000) ? $"\nYear: {_releasedYear}" : "";
            detailsMsg += (_publisher != "Unknown") ? $"\nPublisher: {_publisher}" : "\n";

            return detailsMsg;
        }

        /*
        We should create a public method to access the class field, 
        instead of making them public!
        Below we are adding Getters and Setters as we do with other OOP languages,
        In the next examples, we will use the C# statements/syntax for Properties
        */
        public string GetName()
            {
                return Name;
            }

        public void SetName(string name)
            {
                Name = name;
            }


        public string GetAuthor()
        {
            return Author;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

    } // class
} // namespace