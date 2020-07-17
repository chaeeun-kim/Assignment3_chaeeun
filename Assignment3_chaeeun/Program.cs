using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///-----------------------------------------------------------------
///   Author's name:  chaeeun kim
///   Author's student number: 301060073
///   Date last modified :
///   Program Description: this program shows giantplanet object and terrestrialplanet object.
///   when it comes to giantplanet object, it shows the name ,diameter ,mass, type, whetherit has moon or not,and whether it has rings or not.
///   when it comes to terrestrialplanet object, it shows the name, diameter, mass, whetherit has moon or not, and whether it has oxygen or not.
///   Revision History:
///   
///----------------------------------------------------------------


namespace Assignment3_chaeeun
{
    class Program
    {
        static void Main(string[] args)
        {
           

            GiantPlanet giantPlanet = new GiantPlanet("JUPITER", 139820, 94723984723947324, "GAS", 0, 5,12,9);
            Console.WriteLine("GIANT PLANET");
            Console.WriteLine(giantPlanet.ToString());
           
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("EARTH", 12742, 38383939, true, 5,365,23.25);
            Console.WriteLine("\nTERRESTRIAL PLAENT");
            Console.WriteLine(terrestrialPlanet.ToString());
            waitForAnyKey();

        }

        public static void waitForAnyKey()

        {

            Console.ReadKey();

        }



    }

}

