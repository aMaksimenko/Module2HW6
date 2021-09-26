using System;
using HomeWork.Helpers;
using HomeWork.Models;
using HomeWork.Services.Abstractions;

namespace HomeWork
{
    public class App
    {
        private readonly Random _random;
        private readonly IHomeService _homeService;

        public App(IHomeService homeService)
        {
            _homeService = homeService;
            _random = new Random();
        }

        public void Run()
        {
            var appliances = _homeService.GetAppliances();

            GetPowerConsumption(appliances);
            SortByPower(appliances);
            FindByPowerInRange(appliances);
        }

        public void GetPowerConsumption(Appliance[] appliances)
        {
            ToggleOnRandomly(appliances);

            Console.WriteLine("----------GetPowerConsumption------------");
            Console.WriteLine(_homeService.GetPowerConsumption());
            Console.WriteLine("----------------------");
        }

        public void ToggleOnRandomly(Appliance[] appliances)
        {
            foreach (var appliance in appliances)
            {
                if (_random.Next(2) == 0)
                {
                    appliance.IsOn = !appliance.IsOn;
                }
            }
        }

        public void SortByPower(Appliance[] appliances)
        {
            Console.WriteLine("-----------Non-Sorted-----------");

            foreach (var appliance in appliances)
            {
                Console.WriteLine($"{appliance} -> {appliance.PowerConsumptionMax}");
            }

            Array.Sort(appliances, new PowerComparer());
            Console.WriteLine("----------------------");
            Console.WriteLine("-----------Sorted-----------");

            foreach (var appliance in appliances)
            {
                Console.WriteLine($"{appliance} -> {appliance.PowerConsumptionMax}");
            }

            Console.WriteLine("----------------------");
        }

        public void FindByPowerInRange(Appliance[] appliances)
        {
            var result = appliances.FindByPowerInRange(90, 110);

            Console.WriteLine("-----------FindByPowerInRange-----------");
            Console.WriteLine($"{result} -> {result.PowerConsumptionMax}");
            Console.WriteLine("----------------------");
        }
    }
}