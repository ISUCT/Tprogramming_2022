namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            Russia rus = new ("Russia", "Moskow", 17000);
            Canada can = new ("Canada", "Ottawa", 9000);
            USA usa = new ("USA", "Washington", 7000);

            var countryList = new List<Country>
            {
                    rus, can, usa,
            };

            foreach (var country in countryList)
            {
                Console.WriteLine(country.NameOfElement());
                country.Print();
                Console.Write(country.CountryAge());
                Console.WriteLine(country.PresidentsName());
            }
        }
    }
}