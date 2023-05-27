using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP5ToString
{
    /*
    As with Java all the classes inherit from (extend) the mother class "Object",
    same with C#, all classes inherit from the base class "Object".
    Link: https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0

    The base class "Object" has a method named "ToString()"
    to return a string that represents the current object
    Link: https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0

    As we do in Java, we can also override this "virtual" method to print return a custom text
    */
    class Book
    {
        private string _name;
        private string _author;
        private string _publisher;
        int _pageCount;
        int _releasedYear;

        public Book(string name, string author, string publisher = "Unknown")
        {
            _name = name;
            _author = author;
            _publisher = publisher;
        }

        public Book(string name, string author, string publisher = "Unknown", int pages = 0, int year = 0)
        {
            _name = name;
            _author = author;
            _publisher = publisher;
            _pageCount = pages;
            _releasedYear = year;
        }

        public Book()

        {
            /*
            Notice if we don't add the following 3 statements,
            Warning => Nonnullable field...
             */
            _name = string.Empty;
            _author = string.Empty;
            _publisher = string.Empty;
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
                _name = value;
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
            get => _publisher;
            // We can remove the "set" statement and this will make this property for Reading Only
            // set => _publisher = value;
        }

        public int PageCount
        {
            get => _pageCount; set => _pageCount = value;
        }

        /*
         Using auto-generated properties.
         A type of properties that don't have class fields
         they are all in one (a class field and a property at the same time)

         In other words, they hold the data beside controlling their access
         */
        public string ISBN
        {
            get;
            set;
        } = string.Empty;
       
        public decimal Price
        {
            get;
            set;
        }

        /*
        Overriding the method ToString():
        It has the same signature as the method in the base class
        but different contents (function)
        */
        public override string ToString()
        {
            string detailsMsg = Name + " By " + Author;
            detailsMsg += (PageCount > 0) ? $"\nPage: {PageCount}" : "";

            // Notice that we haven't created properties for this field: _releasedYear
            detailsMsg += (_releasedYear > 2000) ? $"\nYear: {_releasedYear}" : "";
            detailsMsg += (Publisher != "Unknown") ? $"\nPublisher: {Publisher}" : "\n";

            return detailsMsg;
        }

        /*
        As with Java also with C#:
        If two methods of a class:
            > whether both declared in the same class
            > or both inherited by a class 
            > or one declared and one inherited
        have the same name but signatures that are not override-equivalent, 
        then the method name is said to be "overloaded".

        In the example below we are overloading the method ToString() NOT overriding!
        so we don't use the keyword/modifier "override":
         */
        public string ToString(int option)
        {
            string msg;
            if (option==1) // return basic simple output:
            {
                msg = Name + " - " + Author;
                return msg;
            } 
            else if (option==2) // return detailed output:
            {
                msg = "Title: "+Name + ". Author: " + Author;
                msg += (PageCount > 0) ? $"\nPages: {PageCount}" : "";

                // Notice that we haven't created properties for this field: _releasedYear
                msg += (_releasedYear > 2000) ? $"\nReleased Year: {_releasedYear}" : "";
                msg += (Publisher != "Unknown") ? $"\nPublisher: {Publisher}" : "\n";
                return msg;
            }
            else
            {
                /*
                NOTE:
                Notice that this final return will call the override method ToString()
                that we defined in this class.
                Comment the override method ToString() if you want to call ToString()
                from the base class Object:
                */
                return ToString();
            }
        } // ToString(int option)
    } // class
} // namespace
