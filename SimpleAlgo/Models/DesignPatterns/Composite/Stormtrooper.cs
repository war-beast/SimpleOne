using SimpleAlgo.Enums;

namespace SimpleAlgo.Models.DesignPatterns.Composite;

/// <summary>
/// Штурмовик (человек/робот)
/// </summary>
public class Stormtrooper : CombatUnitBase
{
	public Stormtrooper() : base(CombatUnitTypes.Stormtrooper)
	{
	}
}