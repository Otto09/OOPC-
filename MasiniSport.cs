using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    class MasiniSport : Masini, ISportCar
    {
        public string spoilers;
        public void GetRaceTrackLapTime()
        {
            Console.WriteLine("This method record Racetrack Laptime");
        }

        public override void GetTurbo() // Polimorfism
        {
            Console.WriteLine("This method is for high speed");
        }
    }
}
