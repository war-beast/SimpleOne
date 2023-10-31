using SimpleAlgo.Interfaces;
using SimpleAlgo.Interfaces.SortingAlgorithms;

namespace SimpleAlgo.Services.SortingAlgorithms;

public class QuickSortingStrategy<T> : SortingStrategyBase<T>, IQuickSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		return QuickSort(array, 0, array.Length - 1);
	}

	private static T[] QuickSort(T[] array, int left, int right)
	{
		if (left >= right)
		{
			return array;
		}

		var pivotIndex = right--;

		var i = left;
		var j = right;

		while (left < right)
		{
			while (array[left].CompareTo(array[pivotIndex]) <= 0 && left < right)
			{
				left++;
			}

			while (array[right].CompareTo(array[pivotIndex]) >= 0 && left < right)
			{
				right--;
			}

			if (left < right)
			{
				Swap(ref array[left], ref array[right]);
			}
		}

		if (array[pivotIndex].CompareTo(array[right]) < 0)
		{
			Swap(ref array[right], ref array[pivotIndex]);
		}

		pivotIndex = left;
		left = i;
		right = j;

		if (left < pivotIndex)
			QuickSort(array, left, pivotIndex);

		if (right > pivotIndex)
			QuickSort(array, pivotIndex, right + 1);

		return array;
	}
}