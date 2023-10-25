using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public abstract class SortingStrategyBase<T> : ISortAlgorithm<T> where T : IComparable<T>
{
	public abstract T[] Sort(T[] array);
}