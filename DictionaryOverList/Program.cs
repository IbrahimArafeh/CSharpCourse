using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOverList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this using List
            Console.WriteLine("------------------------Coding using list ----------------------------------");
            List<Country> countriesList = new List<Country>() { 
                new Country{CountryCaptial="Damascus",CountryCode="SY",CountryName="Syria"},
                new Country{CountryCaptial="Abu Dhabi",CountryCode="UAE",CountryName="United Arab Emirates"},
                new Country{CountryCaptial="Bairout",CountryCode="LBN",CountryName="Lebanon"},
                new Country{CountryCaptial="washington",CountryCode="USA",CountryName="United State Of America"},
            };
            string userContiuedOption = string.Empty;

            do
            {
                Console.WriteLine("Enter the country code :");
                string userContryCode = Console.ReadLine().ToUpper();
                Country selectedCountry = countriesList.Find(c => c.CountryCode == userContryCode);

                if (selectedCountry == null)
                {
                    Console.WriteLine("Please Entry other Country code");
                }
                else
                {
                    Console.WriteLine("The Country Name: {0} and Capital  : {1}", selectedCountry.CountryName, selectedCountry.CountryCaptial);
                }
                do
                {
                    Console.WriteLine("if you want to continue please write YES if no Write NO");
                    userContiuedOption = Console.ReadLine().ToUpper();
                }
                while (userContiuedOption != "YES" && userContiuedOption != "NO");
            }
            while (userContiuedOption == "YES");


            // this using List
            Console.WriteLine("------------------------Coding using Dictionary ----------------------------------");
            Dictionary<string, Country> countriesDic = new Dictionary<string,Country>();
            Country country1 = new Country() { CountryCaptial = "Damascus", CountryCode = "SY", CountryName = "Syria" };
            Country country2 = new Country() { CountryCaptial = "Abu Dhabi", CountryCode = "UAE", CountryName = "United Arab Emirates" };
            Country country3 = new Country() { CountryCaptial = "Bairout", CountryCode = "LBN", CountryName = "Lebanon" };
            Country country4 = new Country() { CountryCaptial = "washington", CountryCode = "USA", CountryName = "United State Of America" };
            countriesDic.Add(country1.CountryCode,country1);
            countriesDic.Add(country2.CountryCode,country2);
            countriesDic.Add(country3.CountryCode,country3);
            countriesDic.Add(country4.CountryCode,country4);

            string userContiuedOption2 = string.Empty;

            do
            {
                Console.WriteLine("Enter the country code :");
                string userContryCode = Console.ReadLine().ToUpper();
                Country selectedCountry = countriesDic.ContainsKey(userContryCode) ? countriesDic[userContryCode] : null;

                if (selectedCountry == null)
                {
                    Console.WriteLine("Please Entry other Country code");
                }
                else
                {
                    Console.WriteLine("The Country Name: {0} and Capital  : {1}", selectedCountry.CountryName, selectedCountry.CountryCaptial);
                }
                do
                {
                    Console.WriteLine("if you want to continue please write YES if no Write NO");
                    userContiuedOption = Console.ReadLine().ToUpper();
                }
                while (userContiuedOption2 != "YES" && userContiuedOption2 != "NO");
            }
            while (userContiuedOption2 == "YES");


        }
    }

    internal class Country
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCaptial { get; set; }
    }
}
