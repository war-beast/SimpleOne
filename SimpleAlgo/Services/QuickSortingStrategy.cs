using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class QuickSortingStrategy<T> : SortingStrategyBase<T>, IQuickSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		throw new NotImplementedException();
	}
}