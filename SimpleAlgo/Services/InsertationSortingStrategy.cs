using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class InsertationSortingStrategy<T> : SortingStrategyBase<T>, IInsertationSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		throw new NotImplementedException();
	}
}