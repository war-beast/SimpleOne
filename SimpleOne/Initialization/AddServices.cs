using SimpleAlgo.Interfaces;
using SimpleAlgo.Services;

namespace SimpleOne.Initialization;

public static class AddServices
{
	public static void AddCustomServices(this IServiceCollection services)
	{
		services.AddTransient(typeof(ISortAlgoFactory<>), typeof(SortAlgoFactory<>));
		services.AddTransient(typeof(IBubbleSortingStrategy<>), typeof(BubbleSortingStrategy<>));
		services.AddTransient(typeof(IShakerSortingStrategy<>), typeof(ShakerSortingStrategy<>));

		services.AddTransient(typeof(IAlgorithmsService<>), typeof(AlgorithmsService<>));
	}
}