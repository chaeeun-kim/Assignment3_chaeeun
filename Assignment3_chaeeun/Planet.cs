using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_chaeeun
{
    abstract class Planet
    {


        //fields
        private double _diameter;

        private double _mass;

        private int _moonCount;

        private string _name;

        private double _orbitalPeriod;

        private int _ringCount;

        private double _rotationperiod;



        //property



        public double Diameter

        {

            get { return _diameter; }



        }

        public double Mass

        {

            get { return _mass; }

        }

        public int MoonCount

        {

            get

            { return _moonCount; }



            set { _moonCount = value; }

        }



        public string Name
        {
            get { return _name; }
        }



        public double OrbitalPeriod

        {

            get

            { return _orbitalPeriod; }



            set { _orbitalPeriod = value; }

        }



        public int RingCount

        {

            get

            { return _ringCount; }

            set { _ringCount = value; }

        }



        public double RotationPeriod
        {

            get

            { return _rotationperiod; }

            set { _rotationperiod = value; }

        }



        //constructor

        public Planet(string name, double diameter, double mass)

        {

            this._name = name;

            this._diameter = diameter;

            this._mass = mass;

        }

        //method

        public override string ToString()

        {

            return $"NAME:{_name} DIAMETER:{_diameter}KM  MASS:{_mass}KG";

        }



    }
}
