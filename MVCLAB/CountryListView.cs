using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLAB
{
    public class CountryListView(List<Country> countries)
    {
        public List<Country> Countries { get; set; } = countries;

        public void Display()
        {
            Console.WriteLine("List of Countries:");
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Countries[i].Name}");
            }
        }


    }
}
