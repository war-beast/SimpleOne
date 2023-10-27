using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class MergeSortingStrategy<T> : SortingStrategyBase<T>, IMergeSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		throw new NotImplementedException();
	}
}