using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating.Resistive
{
    public class Lamp : Resistive
    {
        public override int PowerConsumptionMax { get; init; } = 80;
        public override Size Size { get; init; } = Size.Small;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Analogue;
    }
}