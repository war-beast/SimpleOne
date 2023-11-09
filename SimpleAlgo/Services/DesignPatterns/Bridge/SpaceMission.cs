using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;
using SimpleAlgo.Models;
using System.Text;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class SpaceMission : CombatMissionBase
{
	public SpaceMission(IShipStorage storage) : base(storage)
	{
	}

	public override MissionType GetMissionType() => MissionType.Space;

	public override Result<string> Fight()
	{
		var sb = new StringBuilder();
		sb.AppendLine(GetMissionType().GetEnumDescription());
		sb.AppendLine(">------Начинаем уничтожение вражеского флота вторжения------<");

		foreach (var ship in Ships)
		{
			sb.AppendLine(ship.Attack());
		}

		sb.AppendLine(">------Миссия выполнена!------<");
		sb.AppendLine(string.Empty);

		return Result.Success(sb.ToString());
	}
}