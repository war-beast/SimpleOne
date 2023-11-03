using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class ShipBase
{
	public ShipBase(BattleShipType type)
	{
		Name = type.GetEnumDescription();
	}

	protected string Name { get; }
}