using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;
using SimpleAlgo.Models.DesignPatterns.Flyweight;
using SimpleAlgo.Services.DesignPatterns.Bridge;

namespace SimpleAlgo.Services.DesignPatterns.Flyweight;

public class ShipStorage : IShipStorage
{
	private readonly IBattleShipFactory _battleShipFactory;

	public ShipStorage(IBattleShipFactory battleShipFactory)
	{
		_battleShipFactory = battleShipFactory;
	}

	public IReadOnlyCollection<IBattleShip> ProduceShips(IReadOnlyCollection<ShipOrder> orders)
	{
		var battleShipCount = orders.Where(x => x.Type == BattleShipType.BattleShip).Sum(x => x.Count);
		var carrierCount = orders.Where(x => x.Type == BattleShipType.Carrier).Sum(x => x.Count);
		var fighterCount = orders.Where(x => x.Type == BattleShipType.Fighter).Sum(x => x.Count);

		List<IBattleShip> ships = new (FillShips<BattleShip>(battleShipCount));
		ships.AddRange(FillShips<Carrier>(carrierCount));
		ships.AddRange(FillShips<Fighter>(fighterCount));

		return ships;
	}

	private IEnumerable<IBattleShip> FillShips<T>(int count) where T : IBattleShip
	{
		var type = typeof(T) switch
		{
			{ } t when t == typeof(BattleShip) => BattleShipType.BattleShip,
			{ } t when t == typeof(Carrier) => BattleShipType.Carrier,
			_ => BattleShipType.Fighter
		};

		List<IBattleShip> list = new(count);
		for (var i = 0; i < count; i++)
		{
			list.Add(_battleShipFactory.GetShip(type));
		}

		return list;
	}
}