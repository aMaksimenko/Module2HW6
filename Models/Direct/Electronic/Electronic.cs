using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct.Electronic
{
    public abstract class Electronic : Direct
    {
        public override ApplianceType Type { get; init; } = ApplianceType.Electronic;
    }
}