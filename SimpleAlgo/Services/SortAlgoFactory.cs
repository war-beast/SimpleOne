using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class SortAlgoFactory<T> : ISortAlgoFactory<T> where T : IComparable<T>
{
	private readonly Dictionary<SortTypes, ISortAlgorithm<T>> _sortAlgorithms;

	public SortAlgoFactory(IBubbleSortingStrategy<T> bubbleSortingStrategy,
		IShakerSortingStrategy<T> shakerSortingStrategy)
	{
		_sortAlgorithms = new Dictionary<SortTypes, ISortAlgorithm<T>>
		{
			{ SortTypes.BubbleSort, bubbleSortingStrategy },
			{ SortTypes.ShakerSort, shakerSortingStrategy }
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