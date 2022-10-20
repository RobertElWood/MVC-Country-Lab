using System.ComponentModel.DataAnnotations;

namespace MVC_Country_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates instance of the controller
            CountryController programStart = new CountryController();

            //Calls the method to start the program, contained within the controller class
            programStart.WelcomeAction();
        }
    }
}