using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleAlgo.Services.DesignPatterns.Visitor;

public class SuspendedWeaponTuningVisitor  : IShipWeaponTuningVisitor
{
	public string TuneLightShipWeapon(IShipWeaponContainable ship)
	{
		return $"Корабль типа \"{ship.Name}\". Настройка пусковой системы ракет ближнего боя.";
	}

	public string TuneMiddleShipWeapon(IShipWeaponContainable ship)
	{
		return $"Корабль типа \"{ship.Name}\". Настройка торпедных аппаратов.";
	}

	public string TuneHeavyShipWeapon(IShipWeaponContainable ship)
	{
		return $"Корабль типа \"{ship.Name}\". Настройка систем ПКО.";
	}
}