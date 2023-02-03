using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Design_Patterns_Lab;

namespace Design_Patterns_Lab
{
    //List<Country> CountryDb - this stands in for our country database.We’ll learn those later, but know the info from the database gets stored in a list
    //Public void CountryAction(Country c) . 
    //Public void WelcomeAction() - This will take no parameter and pass CountryDb into the CountryListView class. Then, it will print “Hello, welcome to the country app.Please select a country from the following list:” Then it will call Display() on the CountryListView.
    //Next allow the user to select a country by index.Upon getting the country out of CountryDb, pass that country along to the CountryAction() method. After that’s done, ask if the user would like to learn about another country.


    public class CountryController
    {
        //properties
        public List<Country> CountryDb { get; set; }


        //- This will take in a Country model, passing the model into the
        //CountryView constructor, and call Display Country on your CountryView object

        //Constructor
        public CountryController()
        {
            CountryDb = new List<Country>
            {
                new Country("USA1", "North America", new List<string>() { "blue", "red", "white" }),
                new Country("USA2", "North America", new List<string>() { "blue", "red", "white" }),
                new Country("USA3", "North America", new List<string>() { "blue", "red", "white" }),
            };
        }


        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }
        public void WelcomeAction()
        {
           
            while(true)
            {
                Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");

                CountryListView viewL = new CountryListView (CountryDb);
                viewL.Display();

                int userInput = 1;
                CountryAction(CountryDb[userInput]);
            }
       
        }

    }

}