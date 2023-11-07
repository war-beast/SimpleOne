using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;

namespace SimpleAlgo.Models.DesignPatterns.Bridge;

public class Fighter : ShipBase, IBattleShip
{
    public Fighter(BattleShipType type) : base(type)
    {
    }

    public string Attack()
    {
        return $"{Name}: Атака с использованием плазменных курсовых пулемётов и лёгких ракет.";
    }

    public string Defense()
    {
        return $"{Name}: Защита объекта от вражеских истребителей и торпед.";
    }
}