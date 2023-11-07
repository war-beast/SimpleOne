using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Shared;

namespace SimpleAlgo.Interfaces.DesignPatterns.Visitor;

public interface IShipWeaponContainable : INameAndType<BattleShipType>
{
	string Accept(IShipWeaponTuningVisitor visitor);
}