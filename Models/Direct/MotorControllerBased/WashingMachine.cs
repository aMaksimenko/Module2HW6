using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct.MotorControllerBased
{
    public class WashingMachine : MotorControllerBased
    {
        public override int PowerConsumptionMax { get; init; } = 800;
        public override Size Size { get; init; } = Size.Large;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Digital;
    }
}