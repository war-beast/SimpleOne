using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleAlgo.Models.DesignPatterns.Visitor;

public class Carrier : VisitingShipBase
{
	public Carrier() : base(BattleShipType.Carrier)
	{
	}

	public override string Accept(IShipWeaponTuningVisitor visitor) => visitor.TuneMiddleShipWeapon(this);
}