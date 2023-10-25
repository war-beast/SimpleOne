using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class CombSortStrategy<T> : SortingStrategyBase<T>, ICombSortStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		throw new NotImplementedException();
	}
}