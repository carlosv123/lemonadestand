﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lemonade
{
     public class Customer
    {
        private double thirst;
        private string weather;
        private double temperature;
        private double price;

        public Customer()
        {
            
        }

        public Customer(string weather, double temperature, double price)
        {
            this.weather = weather;
            this.temperature = temperature;
            this.price = price;
        }

        public void GetTimer(string weather, double temperature, double price)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(50);
            stopwatch.Stop();
            Random random = new Random();
            AddRemoveThirst = random.Next(40, 61);

        }

        public double AddRemoveThirst
        {
            get
            {
                return thirst;
            }
            set
            {
                thirst = value;
            }
        }

        public void WeatherThirst(string weatherOfDay)
        {
            switch (weatherOfDay)
            {
                case "sunny":
                    AddRemoveThirst += 20;
                    break;
                case "partyly cloudy":
                    AddRemoveThirst += 15;
                    break;
                case "cloudy":
                    AddRemoveThirst += 10;
                    break;
                case "scattered showers":
                    AddRemoveThirst -= 5;
                    break;
                case "heavy rain":
                    AddRemoveThirst -= 10;
                    break;
                default:
                    break;
            }
        }

        public void TemperatureThirst(double temperature)
        {
            if (temperature > 85)
            {
                AddRemoveThirst += 15;
            }
            else if (temperature > 65 && temperature <= 85)
            {
                AddRemoveThirst += 10;
            }
            else if (temperature > 50 && temperature <= 65)
            {
                AddRemoveThirst += 5;
            }
            else
            {
                AddRemoveThirst -= 5;
            }
        }

        public void PriceThirst(double price)
        {
            if (price > 85)
            {
                AddRemoveThirst -= 10;
            }
            else if (price > 65 && price <= 85)
            {
                AddRemoveThirst -= 5;
            }
            else if (price > 50 && price <= 65)
            {
                AddRemoveThirst += 5;
            }
            else if (price > 25 && price <= 50)
            {
                AddRemoveThirst += 10;
            }
            else
            {
                AddRemoveThirst += 15;
            }
        }
    }
}
