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
            LapTop Acer = new LapTop("Acer", 65, 8, 2.1);
            LapTop MSI = new LapTop("MSI", 85, 16, 2.9);
            Console.WriteLine(Acer.laptop + " 1:\n" + Acer.GetDescription());
            Console.WriteLine(MSI.laptop + " 2:\n" + MSI.GetDescription());

            Server Intel = new Server("Intel", 200, 120, 8);
            Server AMD = new Server("Intel", 300, 140, 12);
            Console.WriteLine(Intel.server + " 1:\n" + Intel.GetDescription());
            Console.WriteLine(AMD.server + " 2:\n" + AMD.GetDescription());

            PlasmTV Samsung = new PlasmTV("Samsung", 300, 32, "1920x1080");
            PlasmTV LG = new PlasmTV("LG", 500, 50, "3840x2160");
            Console.WriteLine(Samsung.plazmTV + " 1:\n" + Samsung.GetDescription());
            Console.WriteLine(LG.plazmTV + " 2:\n" + LG.GetDescription());

            LEDTV Sharp = new LEDTV("Sharp", 350, 40, 60);
            LEDTV Xiaomi = new LEDTV("Xiaomi", 700, 65, 75);
            Console.WriteLine(Sharp.ledTV + " 1:\n" + Sharp.GetDescription());
            Console.WriteLine(Xiaomi.ledTV + " 2:\n" + Xiaomi.GetDescription());

            PleyerDevice Sony = new PleyerDevice("Sharp", 350, "MP3, AVC");
            PleyerDevice Panasonic = new PleyerDevice("Xiaomi", 700, "MP3, Flac");
            Console.WriteLine(Sony.pleyer + " 1:\n" + Sony.GetDescription());
            Console.WriteLine(Panasonic.pleyer + " 2:\n" + Panasonic.GetDescription());


            Console.ReadLine();
        }
    }
    class LapTop
    {
        public string laptop = "Laptop";
        protected string Name;
        protected string Power;
        protected string Memory;
        protected string Waight;

        public LapTop(string name, int power, int memory, double waight)
        {
            Name = name;
            Power = $"{power} W";
            Memory = $"{memory} Gb";
            Waight = $"{waight} Kg";
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  Memory: {Memory} {Environment.NewLine}  Waight: {Waight}";
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
    class PleyerDevice
    {
        public string pleyer = "Pleyer Device";
        protected string Name;
        protected string Power;
        protected string KodekSupported;

        public PleyerDevice(string name, int power, string kodek)
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
