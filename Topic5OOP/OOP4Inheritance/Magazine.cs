using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP4Inheritance
{
    class Magazine : Publication
    {
        /*
        Issue in Magazine Publication:
        Issue is the serial number of a publication in a particular year. 
        Example: A magazine that is a monthly publication has 12 issues in a year 
        */
        private int _issue;
        public Magazine(string name, string publisher = "Unknown", int pages = 0, int year = 0, int issue=1, int price = 0)
            : base(name, publisher, pages, year, price)
        {
            _issue = issue;
        }

        // VS IDE Option: Encapsulate field and use property
        public int Issue { get => _issue; set => _issue = value; }

    } // class

} // namespace
