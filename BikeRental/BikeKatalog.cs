using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    internal class BikeKatalog
    {

        public List<Bike> _bikeList;
        public int _antalletafbikes;
        DateTime time;
        public List<Bike> BikeList
        {
            get { return _bikeList; }
            set { _bikeList = value; }
        }

        public BikeKatalog()
        {
            _bikeList = new List<Bike>();
        }

        public void Add(Bike bike)
        {
            _bikeList.Add(bike);
            _antalletafbikes++;
        }

        public void Remove(Bike bike)
        {
            _bikeList.Remove(bike);
        }

        public void update(Bike bike)
        {

        }

        public List<Bike> HentAlleBike()
        {
            
            Console.WriteLine($"Antalet af objecter oprettet {_antalletafbikes}. And the current time is {DateTime.Now}" );

            return _bikeList;
        }

        public Bike SearchBike(int stelnr)
        {
            var foundBike = _bikeList.FirstOrDefault(k => k.Stelnummer == stelnr);

            if (foundBike != null)
            {
                return foundBike;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"{{{nameof(BikeList)}={BikeList}}}";
        }
    }
}
