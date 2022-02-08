using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt11
{
    public abstract class Vehicle
    {
        protected List<string> _visitedCities;
        protected int _mileage;
        protected string[] _descriptions;

        public Vehicle(string [] decriptions)
        {
            _mileage = 0;
            _visitedCities = new List<string>();
            _descriptions = decriptions;
        }

        public void Ride(string city, int mileage) 
        {
            _visitedCities.Add(city);
            if (mileage < 0) throw new Exception("Millage can`t be less than zero!");
            _mileage += mileage;
        }

        public void Resetmileage() 
        {
            _mileage = 0;
        }

        public int GetTotalMileage() 
        {
            return _mileage;
        }

        public List<string> GetAllCities() 
        {
            return _visitedCities;
        }

        public abstract string GetData();
    }
}
