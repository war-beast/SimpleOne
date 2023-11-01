using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class ExponentialSearchStrategy<T> : SearchingStrategyBase<T>, IExponentialSearchStrategy<T> where T : IComparable<T>
{
	public override int Find(T[] array, T searchElement)
	{
		return array.Length == 0
			? AbsentResult
			: ExponentialSearch(array, searchElement);
	}

	private static int ExponentialSearch(T[] array, T searchElement)
	{
		var right = 1;
		var left = 0;

		if (array[left].CompareTo(searchElement) == 0)
		{
			return left;
		}

		while (right < array.Length && array[right].CompareTo(searchElement) <= 0)
		{
			if (array[right].CompareTo(searchElement) == 0)
			{
				return right;
			}

			left = right;
			right <<= 1; //Умножаем на 2
		}

		return right >= array.Length - 1
			? AbsentResult
			: BinarySearch(array, left, right, searchElement);
	}
}