using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class SearchAlgoFactory<T> : ISearchAlgoFactory<T>
{
	private readonly Dictionary<SearchTypes, ISearchAlgorithm<T>> _algorithms;

	public SearchAlgoFactory(IBinarySearchStrategy<T> binarySearchStrategy)
	{
		_algorithms = new Dictionary<SearchTypes, ISearchAlgorithm<T>>{
			{ SearchTypes.Binary, binarySearchStrategy },
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