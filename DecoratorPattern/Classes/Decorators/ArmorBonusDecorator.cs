using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Decorators;

public class ArmorBonusDecorator : IArmorBonus
{
    private readonly IArmorBonus _armorBonus;
    public ArmorBonusDecorator(IArmorBonus armorBonus) { _armorBonus = armorBonus; }
    public virtual string GetBonusType() => _armorBonus.GetBonusType();
    public virtual int GetBonusQuantity() => _armorBonus.GetBonusQuantity();
}
