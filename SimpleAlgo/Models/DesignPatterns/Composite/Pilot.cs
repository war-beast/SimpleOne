using SimpleAlgo.Enums;

namespace SimpleAlgo.Models.DesignPatterns.Composite;

/// <summary>
/// Пилот
/// </summary>
public class Pilot : CombatUnitBase
{
	public Pilot() : base(CombatUnitTypes.Pilot)
	{
	}
}