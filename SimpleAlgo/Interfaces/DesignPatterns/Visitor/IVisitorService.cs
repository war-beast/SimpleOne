using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.DesignPatterns.Visitor;

public interface IVisitorService
{
	Result<string> TuneShips(IReadOnlyList<BattleShipType> types);
}