using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public abstract class SearchingStrategyBase<T> : ISearchAlgorithm<T> where T : IComparable<T>
{
	protected const int AbsentResult = -1;

	public virtual int Find(T[] array, T searchElement)
	{
		return array.Length == 0 
			? AbsentResult 
			: LinearSearch(array, searchElement);
	}

	private static int LinearSearch(IReadOnlyList<T> array, T searchElement)
	{
		for (var i = 0; i < array.Count; i++)
		{
			if (array[i].CompareTo(searchElement) == 0)
			{
				return i;
			}
		}

		return AbsentResult;
	}
}