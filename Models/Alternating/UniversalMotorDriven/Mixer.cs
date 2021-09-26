using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating.UniversalMotorDriven
{
    public class Mixer : UniversalMotorDriven
    {
        public override int PowerConsumptionMax { get; init; } = 1200;
        public override Size Size { get; init; } = Size.Medium;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Analogue;
    }
}