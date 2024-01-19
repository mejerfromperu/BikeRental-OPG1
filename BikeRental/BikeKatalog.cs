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
        public List<Bike> resultatliste;
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
            if (_bikeList.Any(b => b.Stelnummer == bike.Stelnummer))
            {
                throw new ArgumentException($"Bike with ChassisNumber {bike.Stelnummer} already exists in the BikeCatalog.");
            }
            else
            {
                _bikeList.Add(bike);
                _antalletafbikes++;
            }
        }

        public void Remove(int chasisNumber)
        {

            var foundBike = _bikeList.FirstOrDefault(k => k.Stelnummer == chasisNumber);

            if (foundBike != null)
            {
                _bikeList.Remove(foundBike);
            }
            else
            {
                Console.WriteLine("SORRY THE BIKE U WERE TRYING TO DELETE DOESNT EXIST MY FRIEND!");
            }

        }

        public List<Bike> SearchBikesOfModel(string model)
        {
            List<Bike> resultatliste = new List<Bike>();

            for (int i = 0; i < _bikeList.Count; i++ )
            {
                if (_bikeList[i].Model == model)
                {
                    resultatliste.Add(_bikeList[i]);

                }
            }
            return resultatliste;

        }


        public List<Bike> DeleteBikesOfModel(string model)
        {
            
            for (int i = 0; i < _bikeList.Count; i++)
            {
                if (_bikeList[i].Model == model)
                {
                    _bikeList.Remove(_bikeList[i]);
                    Console.WriteLine($"The objects {i} was removed" );
                }
            }
            return _bikeList;

        }




        public void update(Bike bike)
        {

        }

        public List<Bike> HentAlleBike()
        {
            
            Console.WriteLine($"Antalet af objecter oprettet {_antalletafbikes}. And the current time is {DateTime.Now}" );

            return _bikeList;
        }

        //public void PrintBikeList()
        //{
        //    Console.WriteLine(_antalletafbikes);
        //    Console.WriteLine(DateTime.Now);
        //    Console.WriteLine(_bikeList);
        //}




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
