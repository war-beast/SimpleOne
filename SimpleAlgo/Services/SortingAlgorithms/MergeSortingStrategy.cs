using SimpleAlgo.Interfaces;
using SimpleAlgo.Interfaces.SortingAlgorithms;

namespace SimpleAlgo.Services.SortingAlgorithms;

public class MergeSortingStrategy<T> : SortingStrategyBase<T>, IMergeSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		return MergeSort(array, 0, array.Length - 1);
	}

	private static T[] MergeSort(T[] array, int start, int end)
	{
		if (end <= start)
		{
			return array;
		}

		var middle = (end - start) / 2 + start;

		MergeSort(array, start, middle);
		MergeSort(array, middle + 1, end);
		Merge(array, start, middle, end);

		return array;
	}

	private static T[] Merge(T[] array, int start, int middle, int end)
	{
		var tempArray = new T[end - start + 1];
		var left = start;
		var right = middle + 1;
		var index = 0;

		while (left <= middle && right <= end)
		{
			if (array[left].CompareTo(array[right]) < 0)
			{
				tempArray[index++] = array[left++];
			}
			else
			{
				tempArray[index++] = array[right++];
			}
		}

		for (var i = left; i <= middle; i++)
		{
			tempArray[index++] = array[i];
		}

		for (var i = right; i <= end; i++)
		{
			tempArray[index++] = array[i];
		}

		for (var i = 0; i < tempArray.Length; i++)
		{
			array[start + i] = tempArray[i];
		}

		return array;
	}
}