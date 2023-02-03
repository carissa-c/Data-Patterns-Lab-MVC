using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Claims;
using Design_Patterns_Lab;
using System.Drawing;
using System.Xml.Linq;

namespace Design_Patterns_Lab
{
//Next Create a CountryView Class.In the constructor require a Country be taken in and set to DisplayCountry.Create the following property and method: 
//Public Country DisplayCountry
//Public void Display() - This method will print out the Name, Continent, and Colors of the Country DisplayCountry property


    public class CountryView
	{
		//property
		public Country DisplayCountry { get; set; }

		//constructor
		public CountryView(Country _displayCountry)
		{
			DisplayCountry = _displayCountry;
		}

		//method
		public void Display()
		{
			Console.WriteLine($"{DisplayCountry.Name} {DisplayCountry.Continent}");

			foreach (string c in DisplayCountry.Colors)
			{
				Console.WriteLine(c);
			}

        }
	}
}
