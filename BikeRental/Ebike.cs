using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    internal class Ebike : Bike
    {
        private string _motor;

        public string Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }


        public Ebike(string motor, int anskaffelse, string model, string stelfarve, int stelnummer)
        {
            _motor = motor;
            _anskaffelseår = anskaffelse;
            _model = model;
            _stelfarve = stelfarve;
            _stelnummer = stelnummer;
        }

        public override string ToString()
        {
            return $"{{{nameof(Motor)}={Motor}, {nameof(Anskaffelseår)}={Anskaffelseår.ToString()}, {nameof(Model)}={Model}, {nameof(Stelfarve)}={Stelfarve}, {nameof(Stelnummer)}={Stelnummer.ToString()}}}";
        }
    }
}
