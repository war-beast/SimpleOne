using System.Data;
using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.DesignPatterns.Visitor;

public interface IShipWeaponContainable
{
	string Accept(IShipWeaponTuningVisitor visitor);

	string Name { get; }

	BattleShipType Type { get; }
}