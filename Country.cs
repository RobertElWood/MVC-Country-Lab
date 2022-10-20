using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Country_Lab
{
    //Enum for continents created
    public enum Continents
    {
        Asia,
        Europe,
        Africa,
        NorthAmerica,
        SouthAmerica,
        Antarctica,
        AustraliaOceania
    }

    //Model containing data for the 'Country' object
    internal class Country
    {
        public string Name { get; set; }

        public Continents Continent { get; set; }

        public List <string> Colors { get; set; }

    }
}
