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
            const string laptop = "Laptop";
            const string server = "Server";
            const string plazmTV = "PlasmTV";
            const string ledTV = "LED TV";
            const string pleyer = "Pleyer Device";
            
            LapTop Acer = new LapTop("Acer", 65, 8, 2.1);
            LapTop MSI = new LapTop("MSI", 85, 16, 2.9);
            Console.WriteLine(laptop + " 1:\n" + Acer.GetDescription());
            Console.WriteLine(laptop + " 2:\n" + MSI.GetDescription());

            Server Intel = new Server("Intel", 200, 120, 8);
            Server AMD = new Server("Intel", 300, 140, 12);
            Console.WriteLine(server + " 1:\n" + Intel.GetDescription());
            Console.WriteLine(server + " 2:\n" + AMD.GetDescription());

            PlasmTV Samsung = new PlasmTV("Samsung", 300, 32, "1920x1080");
            PlasmTV LG = new PlasmTV("LG", 500, 50, "3840x2160");
            Console.WriteLine(plazmTV + " 1:\n" + Samsung.GetDescription());
            Console.WriteLine(plazmTV + " 2:\n" + LG.GetDescription());

            LEDTV Sharp = new LEDTV("Sharp", 350, 40, 60);
            LEDTV Xiaomi = new LEDTV("Xiaomi", 700, 65, 75);
            Console.WriteLine(ledTV + " 1:\n" + Sharp.GetDescription());
            Console.WriteLine(ledTV + " 2:\n" + Xiaomi.GetDescription());

            PleyerDevice Sony = new PleyerDevice("Sharp", 350, true, true);
            PleyerDevice Panasonic = new PleyerDevice("Xiaomi", 700, true, false);
            Console.WriteLine(pleyer + " 1:\n" + Sony.GetDescription());
            Console.WriteLine(pleyer + " 2:\n" + Panasonic.GetDescription());


            Console.ReadLine();
        }
    }
    class LapTop
    {
        public string Name;
        public string Power;
        public string Memory;
        public string Waight;

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
        public string Name;
        public string Power;
        public string Memory;
        public int ProcessorQuantity;

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
        public string Name;
        public string Power;
        public string ScreenDiagonal;
        public string ScreenResolution;

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
        public string Name;
        public string Power;
        public string ScreenDiagonal;
        public string Frequency;

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
        public string Name;
        public string Power;
        public string MP3;
        public string AVC;

        public PleyerDevice(string name, int power, bool mp3, bool avc)
        {
            Name = name;
            Power = $"{power} W";
            MP3 = $"{mp3}";
            AVC = $"{avc}";
        }
        public string GetDescription()
        {
            return $"  Name: {Name} {Environment.NewLine}  Power: {Power} {Environment.NewLine}  MP3: {MP3} {Environment.NewLine}  AVC: {AVC}";
        }
    }
}
