using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public abstract class SearchingStrategyBase<T> : ISearchAlgorithm<T> where T : IComparable<T>
{
	protected const int AbsentResult = -1;

	public virtual int Find(T[] array, T searchElement)
	{
		return array.Length == 0 
			? AbsentResult 
			: LinearSearch(array, 0, array.Length - 1, searchElement);
	}

	/// <summary>
	/// Рекурсивный бинарный поиск. Может использоваться, как часть других алгоритмов
	/// </summary>
	/// <param name="array">Массив</param>
	/// <param name="start">Индекс начала отрезка поиска</param>
	/// <param name="end">Индекс конца отрезка поиска</param>
	/// <param name="searchElement">Искомый элемент</param>
	/// <returns></returns>
	protected static int BinarySearch(IReadOnlyList<T> array, int start, int end, T searchElement)
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

	protected static int LinearSearch(IReadOnlyList<T> array, int start, int end, T searchElement)
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