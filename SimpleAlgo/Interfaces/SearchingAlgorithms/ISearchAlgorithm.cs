using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface ISearchAlgorithm<in T> where T : IComparable<T>
{
	public int Find(T[] array, T searchElement);
}