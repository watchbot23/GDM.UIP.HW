using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Electronics> listOfElectronicDevices = new List<Electronics>();
            LinkedList<Electronics> listOfDevicesInNetWork = new LinkedList<Electronics>();
            LapTop acer = new LapTop("Acer", 500, 8, 2.1);
            listOfElectronicDevices.Add(acer);
            LapTop msi = new LapTop("MSI", 650, 16, 2.9);
            listOfElectronicDevices.Add(msi);
            Console.WriteLine(acer.laptop + " 1:\n" + acer.ToString());
            Console.WriteLine(msi.laptop + " 2:\n" + msi.ToString());

            Server intel = new Server("Intel", 200, 120, 8);
            listOfElectronicDevices.Add(intel);
            Server amd = new Server("AMD", 300, 140, 12);
            listOfElectronicDevices.Add(amd);
            Console.WriteLine(intel.server + " 1:\n" + intel.ToString());
            Console.WriteLine(amd.server + " 2:\n" + amd.ToString());

            PlasmTV samsung = new PlasmTV("Samsung", 300, 32, "1920x1080");
            listOfElectronicDevices.Add(samsung);
            PlasmTV lg = new PlasmTV("LG", 500, 50, "3840x2160");
            listOfElectronicDevices.Add(lg);
            Console.WriteLine(samsung.plazmTV + " 1:\n" + samsung.ToString());
            Console.WriteLine(lg.plazmTV + " 2:\n" + lg.ToString());

            LEDTV sharp = new LEDTV("Sharp", 350, 40, 60);
            listOfElectronicDevices.Add(sharp);
            LEDTV xiaomi = new LEDTV("Xiaomi", 700, 65, 75);
            listOfElectronicDevices.Add(xiaomi);
            Console.WriteLine(sharp.ledTV + " 1:\n" + sharp.ToString());
            Console.WriteLine(xiaomi.ledTV + " 2:\n" + xiaomi.ToString());

            PlayerDevice sony = new PlayerDevice("Sony", 350, "MP3, AVC");
            listOfElectronicDevices.Add(sony);
            PlayerDevice panasonic = new PlayerDevice("Panasonic", 700, "MP3, Flac");
            listOfElectronicDevices.Add(panasonic);
            Console.WriteLine(sony.player + " 1:\n" + sony.ToString());
            Console.WriteLine(panasonic.player + " 2:\n" + panasonic.ToString());

            Console.WriteLine(sony.GetGeneralPower());
            Console.WriteLine(acer.GetGeneralMemory());

            Generator generator = new Generator("Generator", 3000);
            Console.WriteLine(generator.GetAvailablePower());
            Console.WriteLine(generator.GetAvailablePower());

            generator.AllDevicesInNetWork(ref listOfDevicesInNetWork);
            MainProgram(listOfElectronicDevices,ref listOfDevicesInNetWork, generator);

            Console.ReadLine();
        }

        public static void ListOfElectronicDevices(List<Electronics> listOfElectronicDevices)
        {
            Console.WriteLine("-> Devices available:");
            foreach (var device in listOfElectronicDevices)
            {
                Console.WriteLine($" [{device.ID}] {device.Name} - {device.Power} IsInNetwork: {device.IsInNetWork}");
            }
        }

        public static void ConnectChosenDeviceInNetWork(List<Electronics> listOfElectronicDevices, LinkedList<Electronics> listOfDevicesInNetWork, Generator generator)
        {
            Console.WriteLine("Please select the ID of the device (which is not in NetWork already) you want to connect to a NetWork");
            ListOfElectronicDevices(listOfElectronicDevices);
            string deviceID = Console.ReadLine();
            int deviceIDNumeric;
            while (!Int32.TryParse(deviceID, out deviceIDNumeric) || !IsValidID(deviceIDNumeric, listOfElectronicDevices) 
                || GetDeviceByID(deviceIDNumeric, listOfElectronicDevices).IsInNetWork 
                || !generator.IsEnoughOfPower(generator, GetDeviceByID(deviceIDNumeric, listOfElectronicDevices), listOfDevicesInNetWork))
            {
                Console.WriteLine($"-> Invalid ID. Please make sure you enter a correct ID or device is already in Network.");
                MainProgram(listOfElectronicDevices,ref listOfDevicesInNetWork, generator);
            }
            GetDeviceByID(deviceIDNumeric, listOfElectronicDevices).IsInNetWork = true;
            listOfDevicesInNetWork.AddLast(GetDeviceByID(deviceIDNumeric, listOfElectronicDevices));
            generator.UpdateAvailablePower(GetDeviceByID(deviceIDNumeric, listOfElectronicDevices));
            Console.WriteLine("-> " + GetDeviceByID(deviceIDNumeric, listOfElectronicDevices).Name + $" was successfully connected. Power left in generator {generator.GetAvailablePower()}");
        }

        public static Electronics GetDeviceByID(int ID, List<Electronics> listOfElectronicDevices)
        {
            Electronics deviceUnit = null;
            foreach (var device in listOfElectronicDevices)
            {
                if (device.ID == ID)
                {
                    deviceUnit = device;
                }
            }
            return deviceUnit;
        }

        public static bool IsValidID(int ID, List<Electronics> listOfElectronicDevices)
        {
            bool isValidID = false;
            foreach (var device in listOfElectronicDevices)
            {
                if (device.ID == ID)
                {
                    isValidID = true;
                }
            }
            return isValidID;
        }

        public static bool IsValidIDinLinkedList(int ID, LinkedList<Electronics> listOfDevicesInNetWork)
        {
            bool isValidID = false;
            foreach (var device in listOfDevicesInNetWork)
            {
                if (device.ID == ID)
                {
                    isValidID = true;
                }
            }
            return isValidID;
        }

        public static void RemoveDeviceFromNetWork(List<Electronics> listOfElectronicDevices,ref LinkedList<Electronics> listOfDevicesInNetWork, Generator generator)
        {
            Console.WriteLine("Please select the ID of the device you want to remove from a NetWork");
            generator.AllDevicesInNetWork(ref listOfDevicesInNetWork);
            string deviceID = Console.ReadLine();
            int deviceIDNumeric;
            while (!Int32.TryParse(deviceID, out deviceIDNumeric) || !IsValidIDinLinkedList(deviceIDNumeric, listOfDevicesInNetWork))
            {
                Console.WriteLine($"-> Invalid ID. Please make sure you enter a correct ID or device is isn't in Network.");
                MainProgram(listOfElectronicDevices,ref listOfDevicesInNetWork, generator);
            }
            RemoveUnpoweredChain(GetDeviceByID(deviceIDNumeric, listOfElectronicDevices), ref listOfDevicesInNetWork, generator);
            Console.WriteLine("-> " + GetDeviceByID(deviceIDNumeric, listOfElectronicDevices).Name + $" was successfully removed. Power left in generator {generator.GetAvailablePower()}");
        }

        public static void RemoveUnpoweredChain(Electronics device, ref LinkedList<Electronics> listOfDevicesInNetWork, Generator generator)
        {
            var newListOfDevicesInNetWork = new LinkedList<Electronics>();
            for (int i = IndexOfConnectedDeviceToRemove(device, listOfDevicesInNetWork); i < listOfDevicesInNetWork.Count; i++)
            {
                listOfDevicesInNetWork.ElementAt(i).IsInNetWork = false;
                generator.RenewAvailablePower(listOfDevicesInNetWork.ElementAt(i));
            }
            for (int i = 0; i < IndexOfConnectedDeviceToRemove(device, listOfDevicesInNetWork); i++)
            {
                newListOfDevicesInNetWork.AddLast(listOfDevicesInNetWork.ElementAt(i));
            }
            listOfDevicesInNetWork = newListOfDevicesInNetWork;
        }

        public static int IndexOfConnectedDeviceToRemove(Electronics device, LinkedList<Electronics> listOfDevicesInNetWork)
        {
            int index = 0;
            for (int i = 0; i < listOfDevicesInNetWork.Count; i++)
            {
                if (listOfDevicesInNetWork.ElementAt(i) == device)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static void PrintOptionsMenu()
        {
            string[] optionsArray = new string[] { "quit", "connect device in NetWork", "remove device from NetWork", "show all connected devices", "show all available devices", "clear console" };
            Console.WriteLine("\n- - - - - NEW COMMAND - - - - -");
            for (int i = 0; i < optionsArray.Length; i++)
            {
                Console.WriteLine($" [{i}] - {optionsArray[i]}");
            }
        }

        public static void MainProgram(List<Electronics> listOfElectronicDevices,ref LinkedList<Electronics> listOfDevicesInNetWork, Generator generator)
        {
            string response;
            PrintOptionsMenu();
            response = Console.ReadLine();
            while (response != "0")
            {
                switch (response)
                {
                    case "1":
                        ConnectChosenDeviceInNetWork(listOfElectronicDevices, listOfDevicesInNetWork, generator);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "2":
                        RemoveDeviceFromNetWork(listOfElectronicDevices,ref listOfDevicesInNetWork, generator);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "3":
                        generator.AllDevicesInNetWork(ref listOfDevicesInNetWork);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "4":
                        ListOfElectronicDevices(listOfElectronicDevices);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "5":
                        Console.Clear();
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("-> Invalid command");
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;
                }
            }
            Environment.Exit(0);
        }
    }
}
