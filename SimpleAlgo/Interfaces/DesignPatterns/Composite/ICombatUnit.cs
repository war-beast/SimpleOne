using SimpleAlgo.Models.DesignPatterns.Composite;

namespace SimpleAlgo.Interfaces.DesignPatterns.Composite;

/// <summary>
/// Боевая идиница
/// </summary>
public interface ICombatUnit
{
	void Add(CombatUnitBase unit);

	void Remove(CombatUnitBase unit);

	string Expand();

	int ChildCount();
}