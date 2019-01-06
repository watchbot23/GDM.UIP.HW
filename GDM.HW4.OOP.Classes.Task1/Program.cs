using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            LapTop acer = new LapTop("Acer", 65, 8, 2.1);
            LapTop msi = new LapTop("MSI", 85, 16, 2.9);
            Console.WriteLine(acer.laptop + " 1:\n" + acer.GetDescription());
            Console.WriteLine(msi.laptop + " 2:\n" + msi.GetDescription());

            Server intel = new Server("Intel", 200, 120, 8);
            Server amd = new Server("Intel", 300, 140, 12);
            Console.WriteLine(intel.server + " 1:\n" + intel.GetDescription());
            Console.WriteLine(amd.server + " 2:\n" + amd.GetDescription());

            PlasmTV samsung = new PlasmTV("Samsung", 300, 32, "1920x1080");
            PlasmTV lg = new PlasmTV("LG", 500, 50, "3840x2160");
            Console.WriteLine(samsung.plazmTV + " 1:\n" + samsung.GetDescription());
            Console.WriteLine(lg.plazmTV + " 2:\n" + lg.GetDescription());

            LEDTV sharp = new LEDTV("Sharp", 350, 40, 60);
            LEDTV xiaomi = new LEDTV("Xiaomi", 700, 65, 75);
            Console.WriteLine(sharp.ledTV + " 1:\n" + sharp.GetDescription());
            Console.WriteLine(xiaomi.ledTV + " 2:\n" + xiaomi.GetDescription());

            PlayerDevice sony = new PlayerDevice("Sharp", 350, "MP3, AVC");
            PlayerDevice panasonic = new PlayerDevice("Xiaomi", 700, "MP3, Flac");
            Console.WriteLine(sony.player + " 1:\n" + sony.GetDescription());
            Console.WriteLine(panasonic.player + " 2:\n" + panasonic.GetDescription());


            Console.ReadLine();
        }
    }
    class LapTop
    {
        public string laptop = "Laptop";
        protected string Name;
        protected string Power;
        protected string Memory;
        protected string Weight;

        public LapTop(string name, int power, int memory, double weight)
        {
            Name = name;
            Power = $"{power} W";
            Memory = $"{memory} Gb";
            Weight = $"{weight} Kg";
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  Memory: {Memory} {Environment.NewLine}  Waight: {Weight}";
        }
    }
    class Server
    {
        public string server = "Server";
        protected string Name;
        protected string Power;
        protected string Memory;
        protected int ProcessorQuantity;

        public Server(string name, int power, int memory, int processorQuantity)
        {
            Name = name;
            Power = $"{power} W";
            Memory = $"{memory} Gb";
            ProcessorQuantity = processorQuantity;
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  Memory: {Memory} {Environment.NewLine}  Processors Quantity: {ProcessorQuantity}";
        }
    }
    class PlasmTV
    {
        public string plazmTV = "PlasmTV";
        protected string Name;
        protected string Power;
        protected string ScreenDiagonal;
        protected string ScreenResolution;

        public PlasmTV(string name, int power, int screenDiagonal, string screenResolution)
        {
            Name = name;
            Power = $"{power} W";
            ScreenDiagonal = $"{screenDiagonal}''";
            ScreenResolution = $"{screenResolution} Px";
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  Screen Diagonal: {ScreenDiagonal} {Environment.NewLine}  Screen Resolution: {ScreenResolution}";
        }
    }
    class LEDTV
    {
        public string ledTV = "LED TV";
        protected string Name;
        protected string Power;
        protected string ScreenDiagonal;
        protected string Frequency;

        public LEDTV(string name, int power, int screenDiagonal, int frequency)
        {
            Name = name;
            Power = $"{power} W";
            ScreenDiagonal = $"{screenDiagonal}''";
            Frequency = $"{frequency} Hz";
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  ScreenDiagonal: {ScreenDiagonal} {Environment.NewLine}  Frequency: {Frequency}";
        }
    }
    class PlayerDevice
    {
        public string player = "Pleyer Device";
        protected string Name;
        protected string Power;
        protected string KodekSupported;

        public PlayerDevice(string name, int power, string kodek)
        {
            Name = name;
            Power = $"{power} W";
            KodekSupported = $"{kodek}";
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  Supported kodek: {KodekSupported}";
        }
    }
}
