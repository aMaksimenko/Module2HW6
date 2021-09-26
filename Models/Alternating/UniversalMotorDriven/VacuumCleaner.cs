using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating.UniversalMotorDriven
{
    public class VacuumCleaner : UniversalMotorDriven
    {
        public override int PowerConsumptionMax { get; init; } = 1150;
        public override Size Size { get; init; } = Size.Large;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Analogue;
    }
}