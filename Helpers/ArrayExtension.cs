using HomeWork.Models;

namespace HomeWork.Helpers
{
    public static class ArrayExtension
    {
        public static Appliance FindByPowerInRange(this Appliance[] appliances, int minPower, int maxPower)
        {
            Appliance result = null;
            foreach (var appliance in appliances)
            {
                if (appliance != null
                    && appliance.PowerConsumptionMax >= minPower
                    && appliance.PowerConsumptionMax <= maxPower)
                {
                    result = appliance;
                    break;
                }
            }

            return result;
        }
    }
}