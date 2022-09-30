using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public int Year { get; set; } = 2021;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";
        public string TrunkType { get; set; } = "has trunk";
        public string Name { get; set; } = "Toyota Group";
        public string Logo { get; set; } = "──▄████████████████▄────────\r\n─────▄███▀────▄████▄────▀███▄─────\r\n──▄███▀──────▄█▀──▀█▄──────▀███▄──\r\n─▄██▀───────▄█▀────▀█▄───────▀██▄─\r\n▄███▄───────██──────██───────▄███▄\r\n██─▀██▄▄▄▄──██──────██──▄▄▄▄██▀─██\r\n██───▀▀▀██████████████████▀▀▀───██\r\n██──────────██──────██──────────██\r\n██──────────██──────██──────────██\r\n██──────────██──────██──────────██\r\n▀██▄────────██▄────▄██────────▄██▀\r\n─▀██▄───────▀██▄──▄██▀───────▄██▀─\r\n───▀██▄──────▀██████▀──────▄██▀───\r\n─────▀███▄────▀████▀────▄███▀─────\r\n────────▀████████████████▀────────";
        public double EngineSize { get; set; } = 2.0;
        public int SeatCount { get; set; } = 5;
        public int NumberOfWheels { get; set; } = 4;

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
    }
}
