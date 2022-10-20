using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Country_Lab
{
    internal class CountryView
    {
        //View class to display information on individual countries selected by the user.
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        //Display method which displays Name, Continent, and Colors of target country
        //Changes the colors of the foreground and background to match the country's colors by calling the CountryColors() method
        //If statement recognizes if the country in question has a third color. If so, will change the middle line to represent that color.
        public void Display()
        {
            CountryColors(DisplayCountry);
            Console.WriteLine($"\nName of Country:\t{DisplayCountry.Name}\n");
         
            if (DisplayCountry.Colors.Count == 3)
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[2]);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[1]);           
            }

            Console.WriteLine($"Continent:\t\t{DisplayCountry.Continent}\n");


            if (DisplayCountry.Colors.Count == 3) 
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[0]);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[1]);
                
            }
            
            Console.Write($"Country Colors:\t\t");
            writeColors(DisplayCountry.Colors);
            Console.ResetColor(); //resets console colors to default values before re-running app.
        }

        //Iterates through the colors in the list of colors present in Country object.
        //Writes these colors on the same line.
        public void writeColors(List<string> colors)
        {
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }

            Console.WriteLine();
        }

        //Changes the foreground and background to match the first two colors stored in a country's color list.
        public void CountryColors(Country targetCountry)
        {
            string color1 = targetCountry.Colors[0];
            string color2 = targetCountry.Colors[1];

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color1);

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color2);

        }
    }
}
