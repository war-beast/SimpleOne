using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;
using SimpleAlgo.Models;
using System.Text;

namespace SimpleAlgo.Services.DesignPatterns.Bridge;

public class PlanetMission : CombatMissionBase
{
	public PlanetMission(IShipStorage storage) : base(storage)
	{
	}

	public override MissionType GetType() => MissionType.Planet;

	public override Result<string> Fight()
	{
		var sb = new StringBuilder();
		sb.AppendLine(GetType().GetEnumDescription());
		sb.AppendLine(">------Начинаем захват планеты с уничтожением наземных пусковых ракетных шахт------<");

		foreach (var ship in Ships)
		{
			sb.AppendLine(ship.Attack());
		}

		foreach (var ship in Ships)
		{
			sb.AppendLine(ship.Defense());
		}

		sb.AppendLine(">------Миссия выполнена!------<");
		sb.AppendLine(string.Empty);

		return Result.Success(sb.ToString());
	}
}