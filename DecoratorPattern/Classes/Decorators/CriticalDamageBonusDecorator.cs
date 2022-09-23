using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Decorators;

public class CriticalDamageBonusDecorator : ArmorBonusDecorator
{
    private int BonusQuantity { get; }

    public CriticalDamageBonusDecorator(IArmorBonus armorBonus, int bonusQuantity) : base(armorBonus)
    {
        BonusQuantity = bonusQuantity;
    }

    public override string GetBonusType()
    {
        var type = base.GetBonusType();
        type += $"\r\nThis armorBonus has {GetBonusQuantity()} % critical damage multiplier.";
        return type;
    }
    public override int GetBonusQuantity() => BonusQuantity;
}
