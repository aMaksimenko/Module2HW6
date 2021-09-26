using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct.Electronic
{
    public class Notebook : Electronic
    {
        public override int PowerConsumptionMax { get; init; } = 100;
        public override Size Size { get; init; } = Size.Medium;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Digital;
    }
}