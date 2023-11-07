using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleAlgo.Models.DesignPatterns.Visitor;

public class Fighter : VisitingShipBase
{
	public Fighter() : base(BattleShipType.Fighter)
	{
	}

	public override string Accept(IShipWeaponTuningVisitor visitor) => visitor.TuneLightShipWeapon(this);
}