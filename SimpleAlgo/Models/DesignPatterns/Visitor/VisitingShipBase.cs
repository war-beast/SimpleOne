using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Shared;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;
using SimpleAlgo.Models.DesignPatterns.Bridge;

namespace SimpleAlgo.Models.DesignPatterns.Visitor;

public abstract class VisitingShipBase : ShipBase, IShipWeaponContainable
{
	protected VisitingShipBase(BattleShipType type) : base(type)
	{
	}

	public abstract string Accept(IShipWeaponTuningVisitor visitor);

	string INameAndType<BattleShipType>.Name => Name;

	BattleShipType INameAndType<BattleShipType>.Type => Type;
}