using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating.Resistive
{
    public class Toaster : Resistive
    {
        public override int PowerConsumptionMax { get; init; } = 1000;
        public override Size Size { get; init; } = Size.Medium;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Analogue;
    }
}