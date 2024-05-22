using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLAB
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public void CountryAction(Country country)
        {
            var countryView = new CountryView(country);
            countryView.Display();
        }
        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            var countryListView = new CountryListView(CountryDb);
            countryListView.Display();
        }
    }
}

