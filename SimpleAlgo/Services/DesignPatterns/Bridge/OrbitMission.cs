using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;
using SimpleAlgo.Models;
using System.Text;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class OrbitMission : CombatMissionBase
{
	public OrbitMission(IShipStorage storage) : base(storage)
	{
	}

	public override MissionType GetMissionType() => MissionType.Orbit;

	public override Result<string> Fight()
	{
		var sb = new StringBuilder();
		sb.AppendLine(GetMissionType().GetEnumDescription());
		sb.AppendLine(">------Начинаем прикрытие орбитальных защитных станций от вражеского флота вторжения------<");

		foreach (var ship in Ships)
		{
			sb.AppendLine(ship.Defense());
		}

		sb.AppendLine(">------Миссия выполнена!------<");
		sb.AppendLine(string.Empty);

		return Result.Success(sb.ToString());
	}
}