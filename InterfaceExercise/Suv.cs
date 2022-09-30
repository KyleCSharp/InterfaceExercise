using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : ICompany, IVehicle

    {
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Honda";

        public string Model { get; set; } = "CR-V";

        public string TrunkType { get; set; } = "has cargo hold";
        public string Name { get; set; } = "Honda Motor Co.";
        public string Logo { get; set; } = "─▄█████████████████▄─\r\n█▀─────────────────▀█\r\n█──█▌───────────▐█──█\r\n█──██───────────██──█\r\n█──██───────────██──█\r\n█──██▌─────────▐██──█\r\n█──██▌─────────▐██──█\r\n█──▐██─────────██▌──█\r\n█──▐██▄───────▄██▌──█\r\n█──▐████▄▄▄▄▄████▌──█\r\n█──▐█████████████▌──█\r\n█───████▀───▀████───█\r\n█───███───────███───█\r\n█───██▌───────▐██───█\r\n█───▐█▌───────▐█▌───█\r\n█▄─────────────────▄█\r\n─▀█████████████████▀─\r\n─────────────────────\r\n█─█─▄▀▀▄─█▄─█─█▀▄─▄▀▄\r\n█▀█─█──█─█▀██─█─█─█▄█\r\n▀─▀──▀▀──▀──▀─▀▀──▀─▀";
        public double EngineSize { get; set; } = 1.5;
        public int SeatCount { get; set; } = 5;
        public int NumberOfWheels { get; set; } = 4;

        public void Drive()
        {
            Console.WriteLine("can drive if shifted into D.....");
            Console.WriteLine("now in DRIVE");
        }

        public void Park()
        {
            Console.WriteLine("can park if shifted into P....");
            Console.WriteLine("now in PARK");
        }

        public void Reverse()
        {
            Console.WriteLine("can reverse if shifted into R....");
            Console.WriteLine("now in REVERSE");

        }
       
    }
}
