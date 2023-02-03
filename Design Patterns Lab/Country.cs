using System;
using System.Drawing;

namespace Design_Patterns_Lab
{
//Make a Country model with the following properties: 
//Public string Name----------------------------
//Public string Continent----------------------- 
//Public List<string> Colors--------------------


    public class Country
	{
		//properties
		public string Name { get; set; }
		public string Continent { get; set; }
        public List<string>Colors { get; set; }

		//constructor
		public Country(string _name, string _continent, List<string> _colors)
		{
			Name = _name;
			Continent = _continent;
			Colors = _colors;
		}

		
    }
}

