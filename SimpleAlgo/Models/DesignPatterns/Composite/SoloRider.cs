using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Composite;
using SimpleAlgo.Interfaces.DesignPatterns.Prototype;

namespace SimpleAlgo.Models.DesignPatterns.Composite;

/// <summary>
/// Одиночный рейдер
/// </summary>
public class SoloRider : CombatUnitBase, ICloneable<SoloRider>
{
	public SoloRider() : base(CombatUnitTypes.SoloRaider)
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

	/// <summary>
	/// Реализация паттерна прототип
	/// </summary>
	/// <returns></returns>
	public SoloRider Clone()
	{
		var clone = new SoloRider();
		clone.Units.AddRange(Units);

		return clone;
	}
}