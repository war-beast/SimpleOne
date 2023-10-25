using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class BubbleSortingStrategy<T> : SortingStrategyBase<T>, IBubbleSortingStrategy<T> where T : IComparable<T>
{

	public override T[] Sort(T[] array)
	{
		for (var i = 0; i < array.Length; i++)
		{
			for (var j = 0; j < array.Length - 1; j++)
			{
				if (array[j].CompareTo(array[j + 1]) > 0)
				{
					(array[j], array[j + 1]) = (array[j + 1], array[j]);
				}
			}
		}

		return array;
	}
}