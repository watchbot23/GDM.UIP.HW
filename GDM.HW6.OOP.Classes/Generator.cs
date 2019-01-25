using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    public class Generator : Electronics
    {
        public static int AvailablePower { get; set; }
        public Generator(string name, int power) : base(name, power)
        {
            AvailablePower = power;
            IsSorce = true;
        }
        public override string GetDescription()
        {
            return $" Name: {Name} { Environment.NewLine} Power: {Power}";
        }
        public void UpdateAvailablePower(Electronics device)
        {
                AvailablePower -= device.Power;
        }
        public void RenewAvailablePower(Electronics device)
        {
                AvailablePower += device.Power;
        }
        public bool IsEnoughOfPower(Generator generator, Electronics device, LinkedList<Electronics> listOfDevicesInNetWork)
        {
            bool isEnoughOfPower = false;
            if (generator.GetAvailablePower() - device.Power >= 0)
            {
                isEnoughOfPower = true;
            }
            return isEnoughOfPower;
        }

        public int GetAvailablePower()
        {
            return AvailablePower;
        }
        public void AllDevicesInNetWork(ref LinkedList<Electronics> devices)
        {
            Console.WriteLine("-> Devices in NetWork:");
            if (devices.Count < 1)
            {
                Console.WriteLine("-> There is no connected devices in NetWork");
            }
            foreach (var device in devices)
            {
                Console.WriteLine($" [{device.ID}] {device.Name} - {device.Power} W");
            }
        }
    }
}
