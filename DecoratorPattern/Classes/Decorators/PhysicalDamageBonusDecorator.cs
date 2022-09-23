using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Decorators;

public class PhysicalDamageBonusDecorator : ArmorBonusDecorator
{
    private IArmorBonus _armorBonus;
    private int BonusQuantity { get; }

    public PhysicalDamageBonusDecorator(IArmorBonus armorBonus, int bonusQuantity) : base(armorBonus)
    {
        _armorBonus = armorBonus;
        BonusQuantity = bonusQuantity;
    }

    public override string GetBonusType()
    {
        var type = base.GetBonusType();
        type += $"\r\nThis armorBonus has { GetBonusQuantity()} % physical damage multiplier.";
        return type;
    }
    public override int GetBonusQuantity() => BonusQuantity;
}
