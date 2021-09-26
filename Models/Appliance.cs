using HomeWork.Models.Enums;

namespace HomeWork.Models
{
    public abstract class Appliance
    {
        public abstract int PowerConsumptionMax { get; init; }
        public abstract Size Size { get; init; }
        public abstract InterfaceType InterfaceType { get; init; }
        public abstract PowerType PowerType { get; init; }
        public abstract ApplianceType Type { get; init; }
        public bool IsOn { get; set; }
    }
}