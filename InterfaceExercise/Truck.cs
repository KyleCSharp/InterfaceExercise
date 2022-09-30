using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Toyota";

        public string Model { get; set; } = "Trunda";

        public string Trim { get; set; } = "TRD";


        public string TrunkType { get; set; } = "has a short bed";
        public string Name { get; set; } = "Toyota Group";
        public string Logo { get; set; } = "──▄████████████████▄────────\r\n─────▄███▀────▄████▄────▀███▄─────\r\n──▄███▀──────▄█▀──▀█▄──────▀███▄──\r\n─▄██▀───────▄█▀────▀█▄───────▀██▄─\r\n▄███▄───────██──────██───────▄███▄\r\n██─▀██▄▄▄▄──██──────██──▄▄▄▄██▀─██\r\n██───▀▀▀██████████████████▀▀▀───██\r\n██──────────██──────██──────────██\r\n██──────────██──────██──────────██\r\n██──────────██──────██──────────██\r\n▀██▄────────██▄────▄██────────▄██▀\r\n─▀██▄───────▀██▄──▄██▀───────▄██▀─\r\n───▀██▄──────▀██████▀──────▄██▀───\r\n─────▀███▄────▀████▀────▄███▀─────\r\n────────▀████████████████▀────────";
        public double EngineSize { get; set; } = 3.5;
        public int SeatCount { get; set; } = 5;
        public int NumberOfWheels { get; set; } =4;

        public void Drive()
        {
            Console.WriteLine("can drive if shifted into D");
        }

        public void Park()
        {
            Console.WriteLine("can park if shifted into P");
        }

        public void Reverse()
        {
            Console.WriteLine("can reverse if shifted into R");

        }
        public void FourWheel()
        {
            Console.WriteLine("this truck has 4 wheel drive");
        }
    }
}
