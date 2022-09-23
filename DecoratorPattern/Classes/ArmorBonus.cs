using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes;

public class ArmorBonus : IArmorBonus
{
    public string GetBonusType() => string.Empty;
    public int GetBonusQuantity() => 0;
}
