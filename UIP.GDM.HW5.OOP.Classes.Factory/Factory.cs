using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    class Factory
    {
        private List<Order> Orders = new List<Order>();
        private List<Worker> Workers = new List<Worker>();
        public Country Country;
        private string _name;
        public string Name { get; set; }
        private void ExecuteWorkingDay()
        {
            foreach (var worker in this.Workers)
            {

            }
        }
        private void ExecuteWorkingMonth()
        {
            for (int i = 0; i < 30; i++)
            {
                ExecuteWorkingDay();
            }
        }
        public void ExecuteWorkingYear()
        {
            for (int i = 0; i < 12; i++)
            {
                ExecuteWorkingMonth();
            }
        }
    }
}
