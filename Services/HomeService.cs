using System;
using HomeWork.Models;
using HomeWork.Providers.Abstractions;
using HomeWork.Services.Abstractions;

namespace HomeWork.Services
{
    public class HomeService : IHomeService
    {
        public HomeService(IApplianceProvider applianceProvider)
        {
            Appliances = applianceProvider.GetAppliances();
        }

        private Appliance[] Appliances { get; init; }

        public int GetPowerConsumption()
        {
            var result = 0;

            foreach (var appliance in Appliances)
            {
                if (appliance.IsOn)
                {
                    result += appliance.PowerConsumptionMax;
                }
            }

            return result;
        }

        public Appliance[] GetAppliances()
        {
            return Appliances;
        }
    }
}