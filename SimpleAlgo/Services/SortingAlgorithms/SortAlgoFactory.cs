using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces;
using SimpleAlgo.Interfaces.SortingAlgorithms;

namespace SimpleAlgo.Services.SortingAlgorithms;

public class SortAlgoFactory<T> : ISortAlgoFactory<T> where T : IComparable<T>
{
	private readonly Dictionary<SortTypes, ISortAlgorithm<T>> _sortAlgorithms;

	public SortAlgoFactory(IBubbleSortingStrategy<T> bubbleSortingStrategy,
		IShakerSortingStrategy<T> shakerSortingStrategy,
		ICombSortStrategy<T> combSortStrategy,
		IInsertionSortingStrategy<T> insertionSortingStrategy,
		IQuickSortingStrategy<T> quickSortingStrategy,
		IMergeSortingStrategy<T> mergeSortingStrategy)
	{
		_sortAlgorithms = new Dictionary<SortTypes, ISortAlgorithm<T>>
		{
			{ SortTypes.BubbleSort, bubbleSortingStrategy },
			{ SortTypes.ShakerSort, shakerSortingStrategy },
			{ SortTypes.CombSort, combSortStrategy },
			{ SortTypes.InsertionSort, insertionSortingStrategy },
			{ SortTypes.QuickSort, quickSortingStrategy },
			{ SortTypes.MergeSort, mergeSortingStrategy }
		};
	}

	public ISortAlgorithm<T> Create(SortTypes sortType)
	{
		if (_sortAlgorithms.TryGetValue(sortType, out var algorithm))
		{
			return algorithm;
		}

		throw new ArgumentException("Запрошен неизвестный науке алгоритм сортировки");
	}
}