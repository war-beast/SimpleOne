using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class BinarySearchStrategy<T> : SearchingStrategyBase<T>, IBinarySearchStrategy<T> where T : IComparable<T>
{
	private const int AbsentResult = -1;

	public override int Find(T[] array, T searchElement)
	{
		return array.Length == 0 
			? AbsentResult 
			: BinarySearch(array, 0, array.Length - 1, searchElement);
	}

	/// <summary>
	/// Рекурсивный бинарный поиск
	/// </summary>
	/// <param name="array">Массив</param>
	/// <param name="start">Индекс начала отрезка поиска</param>
	/// <param name="end">Индекс конца отрезка поиска</param>
	/// <param name="searchElement">Искомый элемент</param>
	/// <returns></returns>
	private static int BinarySearch(IReadOnlyList<T> array, int start, int end, T searchElement)
	{
		if (end == start && array[end].CompareTo(searchElement) == 0)
		{
			return end;
		}

		if (end == start && array[end].CompareTo(searchElement) != 0)
		{
			return AbsentResult;
		}

		var middle = start + ((end - start) >> 1);

		return searchElement.CompareTo(array[middle]) switch
		{
			< 0 => BinarySearch(array, start, middle - 1, searchElement),
			> 0 => BinarySearch(array, middle + 1, end, searchElement),
			_ => middle
		};
	}
}