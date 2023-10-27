using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public abstract class SortingStrategyBase<T> : ISortAlgorithm<T> where T : IComparable<T>
{
	public abstract T[] Sort(T[] array);

	protected static void Swap(ref T a, ref T b) => (a, b) = (b, a);
}