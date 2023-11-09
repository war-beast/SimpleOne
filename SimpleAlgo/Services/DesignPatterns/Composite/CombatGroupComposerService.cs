using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Composite;
using SimpleAlgo.Models;
using SimpleAlgo.Models.DesignPatterns.Composite;

namespace SimpleAlgo.Services.DesignPatterns.Composite;

public class CombatGroupComposerService : ICombatGroupComposerService
{
	//Сделал так только в целях демонстрации работы паттерна.
	//По уму, тут нужно вынести формирование тактических групп в фабрику и nullble параметр тут вообще не нужен
	public Result<string> Compose(SubdivisionTypes? type)
		=> type switch
		{
			SubdivisionTypes.Squadron => ComposeSquadron(),
			SubdivisionTypes.ReconnaissanceRaid => ComposeRaid(),
			SubdivisionTypes.SabotageGroup => ComposeSabotageGroup(),
			_ => Result.Failure<string>("Не понятно, какую группу сформировать")
		};

	private static Result<string> ComposeSquadron()
	{
		var squadron = new GroupUnit();
		var raider = new SoloRider();
		var pilot = new Pilot();
		raider.Add(pilot);
		AddMany<Stormtrooper>(raider, 5);

		squadron.Add(raider.Clone());
		squadron.Add(raider.Clone());

		return Result.Success(squadron.Expand());
	}

	private static Result<string> ComposeRaid()
	{
		var raider = new SoloRider();
		var pilot = new Pilot();
		raider.Add(pilot); 
		AddMany<Stormtrooper>(raider, 2);

		return Result.Success(raider.Expand());
	}

	private static Result<string> ComposeSabotageGroup()
	{
		var raider = new SoloRider();
		var pilot = new Pilot();
		raider.Add(pilot);
		AddMany<Stormtrooper>(raider, 5);

		return Result.Success(raider.Expand());
	}

	private static void AddMany<T>(ICombatUnit host, int count) where T : CombatUnitBase, new()
	{
		for (var i = 0; i < count; i++)
		{
			host.Add(new T());
		}
	}
}