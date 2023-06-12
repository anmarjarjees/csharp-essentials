using System;

namespace Project3ListCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List is coming from namespace "System.Collections.Generic"

            using var again as we can let C# determine the value types

            List can contain any data types but all the elements are the same
             */
            var names = new List<string> { "<name>", "Ana", "Felipe" };

            // We can use the long way (without var):
            List<string> languages = new List<string> { "JS", "Java", "C#" };

            // Using foreach in to loop through the list
            // we can also use [string name] instead of [var name]
            foreach (var name in names)
            {
                // Using the string public method .ToUpper()
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            // or using the normal loop (too much code!):
            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(languages[i]);
            }

           

            // using the list methods:
            languages.Add("Python");
            languages.Add("Swift");

            Console.WriteLine(languages); // System.Collections.Generic.List`1[System.String]

            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(languages[i]);
            }
            Console.WriteLine();
            // remove:
            languages.Remove("Swift");
            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(languages[i]);
            }

            Console.WriteLine($"The first language is {languages[0]}");

            Console.WriteLine($"The languages list has {languages.Count} language in it");
            Console.ReadLine(); //

            /*
             List<T> => any type (Generic) => Cup<T> :-)
             */

            // Index of element:
            var index = languages.IndexOf("Java");
            Console.WriteLine("index of Java: "+index); // 1
            index = languages.IndexOf("Java");
            Console.WriteLine("index of Ruby: "+index); // -1

            // Sort the list:
            languages.Sort();

            /*
             
             */

        } // Main()
    } // class
} // namespace