using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.DesignPatterns.Bridge;

public interface IBattleShipsBridgeService
{
	Result<string> StartMission(MissionType missionType);
}