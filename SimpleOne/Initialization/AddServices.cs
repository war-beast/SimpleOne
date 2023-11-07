using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;
using SimpleAlgo.Interfaces.DesignPatterns.Flyweight;
using SimpleAlgo.Interfaces.SearchingAlgorithms;
using SimpleAlgo.Interfaces.SortingAlgorithms;
using SimpleAlgo.Models.DesignPatterns.Bridge;
using SimpleAlgo.Services.DesignPatterns.Bridge;
using SimpleAlgo.Services.DesignPatterns.Builder;
using SimpleAlgo.Services.DesignPatterns.FluentBuilder;
using SimpleAlgo.Services.DesignPatterns.Flyweight;
using SimpleAlgo.Services.SearchingAlgorithms;
using SimpleAlgo.Services.SortingAlgorithms;

namespace SimpleOne.Initialization;

public static class AddServices
{
	public static void AddCustomServices(this IServiceCollection services)
	{
		services.AddTransient(typeof(ISortAlgoFactory<>), typeof(SortAlgoFactory<>));
		services.AddTransient(typeof(ISearchAlgoFactory<>), typeof(SearchAlgoFactory<>));

		services.AddTransient(typeof(IBubbleSortingStrategy<>), typeof(BubbleSortingStrategy<>));
		services.AddTransient(typeof(IShakerSortingStrategy<>), typeof(ShakerSortingStrategy<>));
		services.AddTransient(typeof(ICombSortStrategy<>), typeof(CombSortStrategy<>));
		services.AddTransient(typeof(IInsertionSortingStrategy<>), typeof(InsertionSortingStrategy<>));
		services.AddTransient(typeof(IQuickSortingStrategy<>), typeof(QuickSortingStrategy<>));
		services.AddTransient(typeof(IMergeSortingStrategy<>), typeof(MergeSortingStrategy<>));

		services.AddTransient(typeof(IBinarySearchStrategy<>), typeof(BinarySearchStrategy<>));
		services.AddTransient(typeof(IJumpSearchStrategy<>), typeof(JumpSearchStrategy<>));
		services.AddTransient(typeof(IInterpolatedSearchStrategy<>), typeof(InterpolatedSearchStrategy<>));
		services.AddTransient(typeof(IExponentialSearchStrategy<>), typeof(ExponentialSearchStrategy<>));

		services.AddTransient(typeof(IAlgorithmsService<>), typeof(AlgorithmsService<>));
		services.AddTransient(typeof(ISearchingAlgorithmsService<>), typeof(SearchAlgorithmService<>));

		#region DesignPatterns

		services.AddTransient<ICarBuilder, SedanBuilder>();
		services.AddTransient<ICarBuilder, CrossoverBuilder>();
		services.AddTransient<ICarBuilder, BuggyBuilder>();
		services.AddTransient<ICarBuilder, MilitaryCarBuilder>();
		services.AddTransient<ICarBuilderDirectorService, CarBuilderDirectorService>();
		services.AddScoped<ICarBuilderFactory, CarBuilderFactory>();

		services.AddTransient<IFluentCarBuilder, SedanFluentBuilder>();
		services.AddTransient<IFluentCarBuilder, CrossoverFluentBuilder>();
		services.AddTransient<IFluentCarBuilder, BuggyFluentBuilder>();
		services.AddTransient<IFluentCarBuilder, MilitaryFluentCarBuilder>();
		services.AddTransient<IFluentCarBuilderDirectorService, CarFluentBuilderDirectorService>();
		services.AddScoped<IFluentCarBuilderFactory, CarFluentBuilderFactory>();
		
		services.AddSingleton<IBattleShip>(new Fighter(BattleShipType.Fighter));
		services.AddSingleton<IBattleShip>(new Carrier(BattleShipType.Carrier));
		services.AddSingleton<IBattleShip>(new BattleShip(BattleShipType.BattleShip));
		services.AddTransient<ICombatMission, PlanetMission>();
		services.AddTransient<ICombatMission, SpaceMission>();
		services.AddTransient<ICombatMission, OrbitMission>();
		services.AddTransient<IBattleShipsBridgeService, BattleShipsBridgeService>();

		services.AddTransient<IBattleShipFactory, BattleShipFactory>();
		services.AddTransient<IShipStorage, ShipStorage>();

		#endregion
	}
}