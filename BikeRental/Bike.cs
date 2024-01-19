using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    public class Bike
    {
        protected int _anskaffelseår;
        protected string _model;
        protected string _stelfarve;
        protected int _stelnummer; 

        public int Anskaffelseår
        {
            get { return _anskaffelseår; }
            set { _anskaffelseår = value; }

        }

        public string Model
        { 
            get { return _model; } 
            set {  _model = value; }
        }

        public string Stelfarve 
        { 
            get { return _stelfarve;} 
            set { _stelfarve = value; }
        }

        public int Stelnummer
        {
            get { return _stelnummer; }
        }

        public Bike()
        {
            _anskaffelseår = 0;
            _model = "";
            _stelfarve = "";
            _stelnummer++;
        }   

        public Bike(int anskaffelse, string model, string stelfarve, int stelnummer)
        {
            _anskaffelseår = anskaffelse;
            _model = model;
            _stelfarve = stelfarve;
            _stelnummer = stelnummer;
        }

        public override string ToString()
        {
            return $"{{{nameof(Anskaffelseår)}={Anskaffelseår.ToString()}, {nameof(Model)}={Model}, {nameof(Stelfarve)}={Stelfarve}, {nameof(Stelnummer)}={Stelnummer.ToString()}}}";
        }
    }
}
