using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_chaeeun
{
    class GiantPlanet : Planet, IHasRings, IHasMoons

    {

        //filed

        private string _type;

        //constructor

        public GiantPlanet(string name, double diameter, double mass, string type, int moons, int rings, double orbitperiod, double rotation)

           : base(name, diameter, mass)

        {
            
            this._type = type;

            this.RingCount = rings;

            this.MoonCount = moons;
            this.OrbitalPeriod = orbitperiod;
            this.RotationPeriod = rotation;

        }



        //method

        public bool HasMoons()

        {

            if (MoonCount > 0)

            {

                return true;



            }

            else { return false; }



        }
        //method
        public bool HasRings()

        {

            if (RingCount > 0)

            {

                return true;



            }

            else { return false; }



        }
        //method
        public override string ToString()

        {


            return $"NAME:{Name}  DIAMETER:{Diameter}KM  MASS:{Mass}KG  TYPE:{_type}  HAVING Moon?:{(HasMoons() ? "YES" : "NO")}  Having rings?:{(HasRings() ? "YES" : "NO")}\nROTATION PERIOD:{RotationPeriod}HOURS   ORBITAL PERIOD:{OrbitalPeriod}YEARS";

        }





    }
}
