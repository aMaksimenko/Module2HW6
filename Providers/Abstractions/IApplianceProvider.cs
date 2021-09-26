using HomeWork.Models;

namespace HomeWork.Providers.Abstractions
{
    public interface IApplianceProvider
    {
        public Appliance[] GetAppliances();
    }
}