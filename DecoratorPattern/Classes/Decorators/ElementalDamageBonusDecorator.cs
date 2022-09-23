using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Decorators;

public class ElementalDamageBonusDecorator : ArmorBonusDecorator
{
    private IArmorBonus _armorBonus;
    private int BonusQuantity { get; }

    public ElementalDamageBonusDecorator(IArmorBonus armorBonus, int bonusQuantity) : base(armorBonus)
    {
        _armorBonus = armorBonus;
        BonusQuantity = bonusQuantity;
    }

    public override string GetBonusType()
    {
        var type = base.GetBonusType();
        type += $"\r\nThis armorBonus has {GetBonusQuantity()} % elemental damage multiplier.";
        return type;
    }
    public override int GetBonusQuantity() => BonusQuantity;
}
