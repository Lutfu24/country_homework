using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Country
    {
        public string Name;
        City[] _arr;
        static int result;
        public Country(string name)
        {
            Name = name;
            _arr = new City[0];
        }


        public int TotalPopulation(City _city)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = _city;
            for (int i = 0; i < _arr.Length; i++)
            {
                result += _city.Population;
                Console.Clear();
                return result;
            }
            return result;
        }

        public void FindAllByPopulation(int min, int max)
        {
            foreach (City _city in _arr)
            {
                if (_city.Population<1000000 && _city.Population>300000)
                {
                    Console.WriteLine(_city);
                }
            }
        }


    }
}
