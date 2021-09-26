using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating
{
    public abstract class Alternating : Appliance
    {
        public override PowerType PowerType { get; init; } = PowerType.Alternating;
    }
}