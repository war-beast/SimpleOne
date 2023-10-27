using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class ShakerSortingStrategy<T> : SortingStrategyBase<T>, IShakerSortingStrategy<T> where T : IComparable<T>
{
	public override T[] Sort(T[] array)
	{
		return GetSorted(0, array.Length - 1, array);
	}

	private static T[] GetSorted(int left, int right, T[] array)
	{
		while (left < right)
		{
			for (var forwardIndex = left; forwardIndex < right; forwardIndex++)
			{
				if (array[forwardIndex].CompareTo(array[forwardIndex + 1]) > 0)
				{
					Swap(ref array[forwardIndex], ref array[forwardIndex + 1]);
				}
			}

			right--;

			for (var backIndex = right; backIndex > left; backIndex--)
			{
				if (array[backIndex].CompareTo(array[backIndex - 1]) < 0)
				{
					Swap(ref array[backIndex], ref array[backIndex - 1]);
				}
			}

			left++;
		}

		return array;
	}
}