using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleAlgo.Services.DesignPatterns.Visitor;

public class ForwardWeaponTuningVisitor : IShipWeaponTuningVisitor
{
	public string TuneLightShipWeapon(IShipWeaponContainable ship)
	{
		return $"Корабль типа \"{ship.Name}\". Настройка курсовых пулемётов.";
	}

	public string TuneMiddleShipWeapon(IShipWeaponContainable ship)
	{
		return $"Корабль типа \"{ship.Name}\". Настройка плазменной пушки.";
	}

	public string TuneHeavyShipWeapon(IShipWeaponContainable ship)
	{
		return $"Корабль типа \"{ship.Name}\". Настройка курсового орудия.";
	}
}