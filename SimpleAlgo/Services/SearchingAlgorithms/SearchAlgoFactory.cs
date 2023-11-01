using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class SearchAlgoFactory<T> : ISearchAlgoFactory<T> where T : IComparable<T>
{
	private readonly Dictionary<SearchTypes, ISearchAlgorithm<T>> _algorithms;

	public SearchAlgoFactory(IBinarySearchStrategy<T> binarySearchStrategy,
		IJumpSearchStrategy<T> jumpSearchStrategy,
		IInterpolatedSearchStrategy<T> interpolatedSearchStrategy,
		IExponentialSearchStrategy<T> exponentialSearchStrategy)
	{
		_algorithms = new Dictionary<SearchTypes, ISearchAlgorithm<T>>{
			{ SearchTypes.Binary, binarySearchStrategy },
			{ SearchTypes.Jump, jumpSearchStrategy },
			{ SearchTypes.Interpolation, interpolatedSearchStrategy },
			{ SearchTypes.Exponential, exponentialSearchStrategy }
		};
	}

	public ISearchAlgorithm<T> Create(SearchTypes type)
	{
		if (_algorithms.TryGetValue(type, out var strategy))
		{
			return strategy;
		}

		throw new ArgumentException("Выбран неизвестный алгоритм поиска");
	}
}