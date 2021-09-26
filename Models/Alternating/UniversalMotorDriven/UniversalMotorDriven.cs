using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating.UniversalMotorDriven
{
    public abstract class UniversalMotorDriven : Alternating
    {
        public override ApplianceType Type { get; init; } = ApplianceType.UniversalMotorDriven;
    }
}