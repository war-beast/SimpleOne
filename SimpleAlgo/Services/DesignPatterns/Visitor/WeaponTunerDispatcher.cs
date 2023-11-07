using System.Text;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleAlgo.Services.DesignPatterns.Visitor;

public class WeaponTunerDispatcher : IWeaponTunerDispatcher
{
	private readonly List<IShipWeaponContainable> _ships = new();

	public void Add(IShipWeaponContainable ship)
	{
		_ships.Add(ship);
	}

	public void Remove(IShipWeaponContainable ship)
	{
		_ships.Remove(ship);
	}

	public string TuneWeapon(IShipWeaponTuningVisitor visitor)
	{
		StringBuilder sb = new();
		foreach (var ship in _ships)
		{ 
			sb.AppendLine(ship.Accept(visitor));
		}

		return sb.ToString();
	}
}