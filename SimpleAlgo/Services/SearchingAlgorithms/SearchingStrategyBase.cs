using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public abstract class SearchingStrategyBase<T> : ISearchAlgorithm<T>
{
	public abstract T Find(T[] array, T searchElement);
}