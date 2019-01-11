﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    public class Shop
    {
        private string _name;
        private int _numberOfStores;
        public string ShopName
        {
            get { return _name; }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Please write valid (not empty) name for shop");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int NumberOfStores
        {
            get { return _numberOfStores; }
            set
            {
                if (value < 1 && value > 10)
                {
                    Console.WriteLine($"Please write valid (not empty) number of stores for shop.");
                }
                else
                {
                    _numberOfStores = value;
                }
            }
        }
        public MobileStore MobStores { get; set; }
        public MobileStore[] MobStoresArray { get; set; }
        public void SetShopName()
        {
            string shopName;
            do
            {
                Console.WriteLine("Please write valid (not empty) name for shop");
                shopName = Console.ReadLine();
            }
            while (shopName.Length < 1);
            ShopName = shopName;
            Console.WriteLine($"-> Great, the name of shop is '{ShopName}'");
        }
        /// <summary>
        /// sets quantity of stores in the shop
        /// </summary>
        public void SetNumberOfStores()
        {
            string storesNumber;
            int tempNumberNumeric;
            do
            {
                Console.WriteLine($"Please write valid (number > 0 && number <= 10) number of stores for shop '{ShopName}'.");
                storesNumber = Console.ReadLine();
            }
            while (!Int32.TryParse(storesNumber, out tempNumberNumeric) || tempNumberNumeric < 1 || tempNumberNumeric > 10);
            NumberOfStores = tempNumberNumeric;
            Console.WriteLine($"-> Great, the number of stores in shop '{ShopName}' is '{NumberOfStores}'.");
        }

    }
}
