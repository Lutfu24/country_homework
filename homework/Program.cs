namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Turkiye");
            //Country country1 = new Country("Almaniya");
            //Country country2 = new Country("America");
            City city = new City("Ankara",400000);
            City city1 = new City("Istanbul",450000);
            City city2 = new City("Bursa", 480000);

            //City city3 = new City("Berlin");
            //City city4 = new City("Nyu-York");
            //City city5 = new City("Las Vegas");
            Console.WriteLine(country.TotalPopulation(city));
            Console.WriteLine(country.TotalPopulation(city1));
            Console.WriteLine(country.TotalPopulation(city2));
            country.FindAllByPopulation(300000, 1000000);


            //country.FindAllByPopulation(300000,1000000);


        }
    }
}