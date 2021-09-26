using HomeWork.Models;
using HomeWork.Models.Alternating.Resistive;
using HomeWork.Models.Alternating.UniversalMotorDriven;
using HomeWork.Models.Direct.Electronic;
using HomeWork.Models.Direct.MotorControllerBased;
using HomeWork.Providers.Abstractions;

namespace HomeWork.Providers
{
    public class ApplianceProvider : IApplianceProvider
    {
        public Appliance[] GetAppliances()
        {
            return new Appliance[]
            {
                new Lamp(),
                new Lamp(),
                new Lamp(),
                new Lamp(),
                new Lamp(),
                new Toaster(),
                new Mixer(),
                new VacuumCleaner(),
                new Notebook(),
                new Notebook(),
                new Television(),
                new Television(),
                new Television(),
                new AirConditioner(),
                new WashingMachine()
            };
        }
    }
}