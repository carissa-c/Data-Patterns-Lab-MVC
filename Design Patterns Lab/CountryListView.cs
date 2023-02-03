using System;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Xml.Linq;
using Design_Patterns_Lab;

namespace Design_Patterns_Lab
{
    //Next Create a CountryListView class. This view will take a list of countries in its constructor.It should have the following property and method: 
    //Public List<Country> Countries - store the parameter from the constructor here.
    //Public void Display() - Print the name of each country in the list along with the index for each country


    public class CountryListView
    {
        //property
        public List<Country> Countries { get; set; }

        //constructor
        //Public List<Country> Countries - store the parameter from the constructor here.
        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        //method
        public void Display()
		{
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i} {Countries[i].Name}");
            }
        }
    }
}
