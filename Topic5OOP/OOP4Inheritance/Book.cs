using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4Inheritance
{
    public class Book : Publication {
        // No more fields (no need) as they are all declared in the base class

        private string _author=string.Empty;

        /*
        As we use super() within the subclass in Java to refer to the superclass,
        we use the base() within the derived class in C# to refer to the base class

        so we use base() to have the base class "Publication" getting initialized
        when we initialize the derived class "Book"
         */
        public Book(string name, string author, string publisher = "Unknown", int pages = 0, int year = 0, int price = 0) 
            : base(name, publisher, pages, year, price)
        {
            _author = author;
        }

        public string Author
        {
            get => _author; // just return the _author
            set => _author = value ?? ""; // set a value to the _author
        }

        /*
         * The "override" modifier is required to extend or modify the abstract or virtual implementation 
         * of an inherited method, property, indexer, or event.
         * Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
         */
        public override string GetDetails()
        {
            string detailsMsg = Name + " By " + Author;
            detailsMsg += (PageCount > 0) ? $"\nPage: {PageCount}" : "";

            // Notice that we haven't created properties for this field: _releasedYear
            detailsMsg += (Year > 2000) ? $"\nYear: {Year}" : "";
            detailsMsg += (Publisher != "Unknown") ? $"\nPublisher: {Publisher}" : "\n";

            return detailsMsg;
        }

        /*        public string GetPublicationInfo()
        {
            return string.Empty;
        }*/

    } // class
} // namespace
