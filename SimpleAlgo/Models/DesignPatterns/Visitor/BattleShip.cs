using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleAlgo.Models.DesignPatterns.Visitor;

public class BattleShip : VisitingShipBase
{
	public BattleShip() : base(BattleShipType.BattleShip)
	{
	}

	public override string Accept(IShipWeaponTuningVisitor visitor) => visitor.TuneHeavyShipWeapon(this);
}