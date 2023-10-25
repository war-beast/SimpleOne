using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class InsertionSortingStrategy<T> : SortingStrategyBase<T>, IInsertionSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		for (var i = 1; i < array.Length; i++)
		{
			var j = i;
			while (j > 0 && array[j-1].CompareTo(array[j]) > 0)
			{
				(array[j], array[j - 1]) = (array[j - 1], array[j]);

				j--;
			}
		}

		return array;
	}
}