using HomeWork.Models.Enums;

namespace HomeWork.Models.Direct.Electronic
{
    public class Television : Electronic
    {
        public override int PowerConsumptionMax { get; init; } = 350;
        public override Size Size { get; init; } = Size.Large;
        public override InterfaceType InterfaceType { get; init; } = InterfaceType.Digital;
    }
}