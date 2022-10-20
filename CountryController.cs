using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Country_Lab
{
    internal class CountryController
    {
        //Property for list of stored countries
        public List<Country> CountryDb { get; set; } = new List<Country>();

        //Controller object to be called in Main.
        public CountryController()
        {
            List<string> colors1 = new List<string> { "Red", "Blue", "White", };
            CountryDb.Add(new Country() { Name = "United States of America", Continent = Continents.NorthAmerica, Colors = colors1 });

            List<string> colors2 = new List<string> { "Blue", "Yellow" };
            CountryDb.Add(new Country() { Name = "Ukraine", Continent = Continents.Europe, Colors = colors2 });

            List<string> colors3 = new List<string> { "Blue", "Yellow", "Red" };
            CountryDb.Add(new Country() { Name = "Romania", Continent = Continents.Europe, Colors = colors3 });

            List<string> colors4 = new List<string> { "Red", "Yellow" };
            CountryDb.Add(new Country() { Name = "China", Continent = Continents.Asia, Colors = colors4 });

            List<string> colors5 = new List<string> { "Green", "White", "Red" };
            CountryDb.Add(new Country() { Name = "Italy", Continent = Continents.Europe, Colors = colors5 });

            List<string> colors6 = new List<string> { "Blue", "White", "Red" };
            CountryDb.Add(new Country() { Name = "Australia", Continent = Continents.AustraliaOceania, Colors = colors6 });

            List<string> colors7 = new List<string> { "Green", "Yellow", "Red" };
            CountryDb.Add(new Country() { Name = "Ethiopia", Continent = Continents.Africa, Colors = colors7 });

            List<string> colors8 = new List<string> { "Green", "Yellow", "Blue" };
            CountryDb.Add(new Country() { Name = "Brazil", Continent = Continents.SouthAmerica, Colors = colors8 });

            List<string> colors9 = new List<string> { "Red", "Black" };
            CountryDb.Add(new Country() { Name = "Empire of Antarctica *totally real*", Continent = Continents.Antarctica, Colors = colors9 });
        }

        //Method to display welcome information to the user. 
        //Delegates method calls to the 'view' classes at appropriate times to run the application.
        //Contains code to loop the app if desired.
        public void WelcomeAction()
        {
            bool runAgain = true;

            while (runAgain)
            {
                //Creates an instance of CLV using the database of countries.
                CountryListView welcomeView = new CountryListView(CountryDb);

                Console.WriteLine("Hello! Welcome to the Country Colors App! Please select a country from the following list:\n");

                //Displays list from database to user.
                welcomeView.Display();

                Console.WriteLine();

                try
                {
                    //takes user input to select necessary index of country.
                    int input = int.Parse(Console.ReadLine());

                    if (input < 1 || input > 9)
                    {
                        Console.WriteLine($"\nThe number you've entered is out of range. Please enter a number 1-{CountryDb.Count}.\n");
                        continue;
                    }

                    //Binds selected index to the country object at that index.
                    Country chosenCountry = CountryDb[input - 1];

                    //Calls method to display information on that selected country
                    //Through CountryView, also shows colors of that country.
                    CountryAction(chosenCountry);

                } 
                catch (FormatException e)
                {
                    Console.WriteLine("\nPlease enter only the number corresponding to the country you'd like to view.\n");
                    continue;
                } 

                //Calls function to prompt user to run program again, if desired.
                runAgain = viewAgain();
               
            }

        }

        //Method to pass the country chosen by the user to the CountryView to be displayed.
        public void CountryAction(Country targetCountry)
        {
            CountryView DisplayTarget = new CountryView(targetCountry);

            DisplayTarget.Display();

        }
        
        //Method to set boolean condition to re-run, or end, the application.
        public bool viewAgain ()
        {
            Console.WriteLine("\nWould you like to view information on another country? Y/N?\n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine("\nOkay! Lets look up another country.\n");
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nThank you for using the Country Colors App! Goodbye!\n");
                return false;
            }
            else
            {
                Console.WriteLine("\nI'm sorry, I didn't understand that. Please try again.\n");
                return viewAgain();
            }
        }
    }
}
