using SimpleAlgo.Interfaces.DesignPatterns.Bridge;
using SimpleAlgo.Models.DesignPatterns.Flyweight;

namespace SimpleAlgo.Interfaces.DesignPatterns.Flyweight;

/// <summary>
/// Космическая верфь, производящая боевые корабли разных типов
/// </summary>
public interface IShipStorage
{
	IReadOnlyCollection<IBattleShip> ProduceShips(IReadOnlyCollection<ShipOrder> orders);
}