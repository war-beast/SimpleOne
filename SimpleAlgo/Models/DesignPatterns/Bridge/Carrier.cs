using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;

namespace SimpleAlgo.Models.DesignPatterns.Bridge;

public class Carrier : ShipBase, IBattleShip
{
    public Carrier(BattleShipType type) : base(type)
    {
    }

    public string Attack()
    {
        return $"{Name}: Построить истребители в походный ордер.";
    }

    public string Defense()
    {
        return $"{Name}: Отправить истребители на защиту линейных кораблей.";
    }
}