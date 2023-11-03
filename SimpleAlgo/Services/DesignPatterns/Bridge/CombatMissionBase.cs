using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;
using SimpleAlgo.Models;
using SimpleAlgo.Models.DesignPatterns.Flyweight;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public abstract class CombatMissionBase : ICombatMission
{
	private readonly IShipStorage _storage;
	protected IEnumerable<IBattleShip> Ships { get; private set; } = Enumerable.Empty<IBattleShip>();

	public abstract MissionType GetType();

	protected CombatMissionBase(IShipStorage storage)
	{
		_storage = storage;
	}

	public abstract Result<string> Fight();

	public void SetImplementor(ShipOrder[] needShips)
	{
		Ships = _storage.ProduceShips(needShips);
	}
}