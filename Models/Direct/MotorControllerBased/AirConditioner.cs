using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct.MotorControllerBased
{
    public class AirConditioner : MotorControllerBased
    {
        public override int PowerConsumptionMax { get; init; } = 950;
        public override Size Size { get; init; } = Size.Large;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Digital;
    }
}