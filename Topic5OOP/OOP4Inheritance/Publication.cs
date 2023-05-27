using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4Inheritance
{
    // Publication is our base class
    public class Publication
    {
        /*
         Notice below are assigning an empty string to the string variable "_name"
         to avoid the warning: 
         "Non-nullable (property/field) must contain a non-null value when exiting constructor.
          Consider declaring the property as nullable"
        */
        private string _name=string.Empty;
        public Publication(string name, string publisher = "Unknown", int pages = 0, int year = 0, int price=0)
        {
            _name = name;
            /*
            We haven't defined the fields for the following properties,
            so we can just call the property itself for each member
             */
            Publisher = publisher;
            PageCount = pages;
            Year = year;
            Price = price;
        }

            /*
             * Besides using the Constructor to set the values of the object fields,
             * we can also add "getters" and "setters" if needed:
            */
        public string Name { 
            get => _name;
            
            // instead of simple assignment:
            // set => _name = value; 
            // we can add a custom condition: if value is empty => throw an exception
            set {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name value is required");
                }
                _name = value;
            }
        } // Name
                
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        /*
        Adding a method using "virtual" keyword.
        
        IMPORTANT NOTE:
        ***************
        > The virtual keyword is used to modify a method, property, indexer, or event declaration 
        and allow for it to be overridden in a derived class. 
        > By default, methods are non-virtual. You cannot override a non-virtual method.
        > You cannot use the virtual modifier with the static, abstract, private, or override modifiers.
        > It's a public method so it should start with UpperCase, otherwise: Naming rule violation

        Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
         */
        public virtual string GetDetails()
        {
            string detailsMsg = Name;
            detailsMsg += (PageCount > 0) ? $"\nPage: {PageCount}" : "";

            // Notice that we haven't created properties for this field: _releasedYear
            detailsMsg += (Year > 2000) ? $"\nYear: {Year}" : "";
            detailsMsg += (Publisher != "Unknown") ? $"\nPublisher: {Publisher}" : "\n";

            return detailsMsg;
        }

        // Another public method:
        public string GetPublicationInfo()
        {
            return "Publications can include books, magazines, flyers, and any other printing materials.";
        }
    } // class
} // namespace
