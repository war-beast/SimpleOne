using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;
using SimpleAlgo.Models;
using SimpleAlgo.Models.DesignPatterns.Flyweight;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class BattleShipsBridgeService : IBattleShipsBridgeService
{
	private readonly IEnumerable<ICombatMission> _missions;

	public BattleShipsBridgeService(IEnumerable<ICombatMission> missions)
	{
		_missions = missions;
	}

	public Result<string> StartMission(MissionType missionType)
	{
		ICombatMission mission;
		
		//Тут можно использовать Стратегию (полиморфизм),
		//но и так уже 2 паттерна реализуется, поэтому оставлю как есть.
		switch (missionType)
		{
			case MissionType.Planet:
				mission = _missions.First(x => x.GetType() == missionType);
				mission.SetImplementor(new[]
					{
						new ShipOrder(BattleShipType.BattleShip, 2),
						new ShipOrder(BattleShipType.Carrier, 1),
						new ShipOrder(BattleShipType.Fighter, 5)
					}
				);
				break;
			case MissionType.Space:
				mission = _missions.First(x => x.GetType() == missionType);
				mission.SetImplementor(new[]
					{
						new ShipOrder(BattleShipType.BattleShip, 4),
						new ShipOrder(BattleShipType.Fighter, 8)
					}
				);
				break;
			case MissionType.Orbit:
				mission = _missions.First(x => x.GetType() == missionType);
				mission.SetImplementor(new[]
					{
						new ShipOrder(BattleShipType.Carrier, 1),
						new ShipOrder(BattleShipType.Fighter, 10)
					}
				);
				break;
			default:
				throw new ArgumentOutOfRangeException(nameof(missionType), missionType, "Попытка инициировать неизвестный тип миссии.");
		}

		return mission.Fight();
	}
}