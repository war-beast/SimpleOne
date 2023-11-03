using SimpleAlgo.Enums;
using SimpleAlgo.Models;
using SimpleAlgo.Models.DesignPatterns.Flyweight;

namespace SimpleAlgo.Interfaces.DesignPatterns.Bridge;

/// <summary>
/// Абстракция
/// </summary>
public interface ICombatMission
{
	MissionType GetType();

	Result<string> Fight();

	void SetImplementor(ShipOrder[] needShips);
}