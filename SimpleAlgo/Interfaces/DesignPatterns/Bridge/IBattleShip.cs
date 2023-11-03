using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.DesignPatterns.Bridge;

/// <summary>
/// Реализация
/// </summary>
public interface IBattleShip
{
	string Attack();

	string Defense();

	BattleShipType Type { get; }
}