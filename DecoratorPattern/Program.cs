using DecoratorPattern.Classes;
using DecoratorPattern.Classes.Decorators;
using DecoratorPattern.Interfaces;

IArmorBonus armorBonus = new ArmorBonus();
Console.WriteLine(armorBonus.GetBonusType());

var criticalDamageDecorator = new CriticalDamageBonusDecorator(armorBonus, 10);
Console.WriteLine(criticalDamageDecorator.GetBonusType());

var physicalDamageDecorator = new PhysicalDamageBonusDecorator(criticalDamageDecorator, 22);
Console.WriteLine(physicalDamageDecorator.GetBonusType());

var elemntalDamageDecorator = new ElementalDamageBonusDecorator(physicalDamageDecorator, 88);
Console.WriteLine(elemntalDamageDecorator.GetBonusType());