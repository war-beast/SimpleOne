using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class ShipBase
{
	public BattleShipType Type { get; }

	protected string Name { get; }

	public ShipBase(BattleShipType type)
	{
		Name = type.GetEnumDescription();
		Type = type;
	}
}