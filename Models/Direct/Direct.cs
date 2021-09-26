using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct
{
    public abstract class Direct : Appliance
    {
        public override PowerType PowerType { get; init; } = PowerType.Direct;
    }
}