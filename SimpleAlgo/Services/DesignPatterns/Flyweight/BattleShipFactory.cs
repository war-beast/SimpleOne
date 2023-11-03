using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;

namespace SimpleAlgo.Services.DesignPatterns.Flyweight;

public class BattleShipFactory : IBattleShipFactory
{
	private readonly Dictionary<BattleShipType, IBattleShip> _ships;

	public BattleShipFactory(IEnumerable<IBattleShip> ships)
	{
		_ships = ships.ToDictionary(k => k.Type, v => v);
	}

	public IBattleShip GetShip(BattleShipType type)
	{
		if (_ships.TryGetValue(type, out var ship))
		{
			return ship;
		}

		throw new ArgumentException("Запрошен неизвестный тип корабля");
	}
}