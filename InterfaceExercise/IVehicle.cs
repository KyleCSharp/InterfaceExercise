using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle: ICompany
    {
        
        public int Year { get; set; }
        
        public double EngineSize { get; set; }
        public string Model { get; set; }

        public string Make { get; set; }

        public int SeatCount { get; set; }

        public int NumberOfWheels   { get; set; }

        public string TrunkType { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();

        


    }
}
