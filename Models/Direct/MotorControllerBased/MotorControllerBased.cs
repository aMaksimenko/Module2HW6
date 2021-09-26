using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct.MotorControllerBased
{
    public abstract class MotorControllerBased : Direct
    {
        public override ApplianceType Type { get; init; } = ApplianceType.MotorControllerBased;
    }
}