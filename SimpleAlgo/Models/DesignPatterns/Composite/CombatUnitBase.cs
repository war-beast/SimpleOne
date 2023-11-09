using System.Text;
using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Interfaces.DesignPatterns.Composite;
using SimpleAlgo.Interfaces.DesignPatterns.Shared;

namespace SimpleAlgo.Models.DesignPatterns.Composite;

public class CombatUnitBase : ICombatUnit, INameAndType<CombatUnitTypes>
{
	protected List<CombatUnitBase> Units = new();

	protected CombatUnitBase(CombatUnitTypes type)
	{
		Type = type;
		Name = type.GetEnumDescription();
	}

	public virtual void Add(CombatUnitBase unit)
	{
		
	}

	public virtual void Remove(CombatUnitBase unit)
	{
		
	}

	public string Expand()
	{
		StringBuilder sb = new ();
		sb.AppendLine($">---Тактическая группа \"{Name}\"---<");
		foreach (var unit in Units)
		{
			if (unit.ChildCount() > 0)
			{
				sb.AppendLine(unit.Expand());
			}
			else
			{
				sb.AppendLine($"Боевая единица типа \"{unit.Name}\"");
			}
		}
		sb.AppendLine($">---Конец описания группы \"{Name}\"---<");

		return sb.ToString();
	}

	public int ChildCount() => Units.Count;

	public string Name { get; }

	public CombatUnitTypes Type { get; }
}