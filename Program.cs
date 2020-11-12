using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Masini mercedes = new Masini();
            Masini volkswagen = new Masini(10, "Sony", "Volkswagen");
            Masini bmw = new MasiniSport(); // Polimorfism

            float acceleration = mercedes.acceleratie;
            mercedes.faruri = "lumineaza";
            mercedes.StergatoareParbriz = "sterg";

            MasiniSport bugatti = new MasiniSport();
            bugatti.spoilers = "red";
            bugatti.GetRaceTrackLapTime();
            bugatti.radio = "LG";

            bmw.GetTurbo(); // Polimorfism
            bugatti.GetTurbo();


            Console.WriteLine(mercedes.acceleratie);
            Console.ReadKey();
        }
    }
}
