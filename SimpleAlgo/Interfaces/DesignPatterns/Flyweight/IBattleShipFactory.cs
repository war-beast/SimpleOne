using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;

namespace SimpleAlgo.Interfaces.DesignPatterns.Flyweight;

/// <summary>
/// Фабрика кораблей
/// </summary>
public interface IBattleShipFactory
{
	IBattleShip GetShip(BattleShipType type);
}