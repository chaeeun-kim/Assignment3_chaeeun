using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_chaeeun
{
    class TerrestrialPlanet : Planet, IHabitable, IHasMoons

    {

        //private filed

        private bool _oxygen;

        //constructor

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen, int moons,double orbitialper,double rotationper)

             : base(name, diameter, mass)

        {



            this._oxygen = oxygen;



            this.MoonCount = moons;
            this.OrbitalPeriod = orbitialper;
            this.RotationPeriod = rotationper;



        }
        //public method
        public bool HasMoons()

        {

            if (MoonCount > 0)

            {

                return true;



            }

            else { return false; }



        }
        //public method
        public bool Habitable()

        {

            if (_oxygen == true)

            { return true; }

            else { return false; }





        }
        //public method
        public override string ToString()

        {

            return $"NAME:{Name}  DIAMETER:{Diameter}KM  MASS:{Mass}KG  HABITABLE?:{(_oxygen ? "YES" : "NO")}  HAVING Moon:{(HasMoons() ? "YES" : "NO")}\nROTATION PERIOD:{RotationPeriod}HOURS   ORBITAL PERIOD:{OrbitalPeriod}days";

        }

    }
}
