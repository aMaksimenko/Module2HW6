using HomeWork.Models.Enums;

namespace HomeWork.Models.Alternating.Resistive
{
    public abstract class Resistive : Alternating
    {
        public override ApplianceType Type { get; init; } = ApplianceType.Resistive;
    }
}