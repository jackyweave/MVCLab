using MVCLAB;

class Program
{
    static void Main()
    {
        // Create some sample countries
        var countries = new List<Country>
        {
            new Country { Name = "USA", Continent = "North America", Colors = new List<string> { "Red", "White", "Blue" } },
            new Country { Name = "France", Continent = "Europe", Colors = new List<string> { "Blue", "White", "Red" } }
        };

        var controller = new CountryController
        {
            CountryDb = countries
        };

        controller.WelcomeAction();

        bool continueLearning = true;
        while (continueLearning)
        {
            Console.WriteLine("Please enter the index of the country you want to learn about:");
            int selectedIndex = int.Parse(Console.ReadLine()) - 1;

            if (selectedIndex >= 0 && selectedIndex < countries.Count)
            {
                controller.CountryAction(countries[selectedIndex]);

                Console.WriteLine("Would you like to learn about another country? (y/n)");
                string response = Console.ReadLine();
                continueLearning = response.Equals("y", StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
        }

        Console.WriteLine("Thank you!");
    }
}