using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Country_Lab
{
    internal class CountryListView
    {
        public List <Country> Countries { get; set; }

        //object to be called at start of program. Takes in a list of Countries from the controller.
        public CountryListView(List<Country> Countries) 
        {
            this.Countries = Countries;
        }

        //Method to display the index and name of each country in the list.
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i + 1}:\t{Countries[i].Name}");
            }
        }

    }
}
