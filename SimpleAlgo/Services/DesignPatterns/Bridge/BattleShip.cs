using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class BattleShip : ShipBase, IBattleShip
{
	public BattleShip(BattleShipType type) : base(type)
	{
	}

	public string Attack()
	{
		return $"{Name}: Обстрел объекта главным калибром и торпедами с дальних расстояний.";
	}

	public string Defense()
	{
		return $"{Name}: Прикрытие объекта своей тушкой используя турели ПКО.";
	}

	public BattleShipType Type => BattleShipType.BattleShip;
}