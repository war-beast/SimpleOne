using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface ISearchAlgorithm<T>
{
	public T Find(T[] array, T searchElement);
}