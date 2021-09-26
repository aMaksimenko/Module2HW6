using HomeWork.Models;

namespace HomeWork.Services.Abstractions
{
    public interface IHomeService
    {
        public int GetPowerConsumption();
        public Appliance[] GetAppliances();
    }
}