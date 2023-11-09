using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Composite;

namespace SimpleAlgo.Models.DesignPatterns.Composite;

/// <summary>
/// Эскадрилья
/// </summary>
public class GroupUnit : CombatUnitBase
{
	public GroupUnit() : base(CombatUnitTypes.Escadrille)
	{
	}

	public override void Add(CombatUnitBase unit)
	{
		Units.Add(unit);
	}

	public override void Remove(CombatUnitBase unit)
	{
		Units.Remove(unit);
	}
}