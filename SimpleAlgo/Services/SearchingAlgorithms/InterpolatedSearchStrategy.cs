using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;
/// <summary>
/// Чтобы не возиться с определением того, есть ли перегрузки аврифметических операций у обощённого типа, оставим 
/// только поиск по целочисленному массиву
/// </summary>
public class InterpolatedSearchStrategy<T> : SearchingStrategyBase<int>, IInterpolatedSearchStrategy<int>
{
	public override int Find(int[] array, int searchElement)
	{
		return array.Length == 0
			? AbsentResult
			: InterpolatedSearch(array, searchElement, 0, array.Length - 1);
	}

	private static int InterpolatedSearch(IReadOnlyList<int> array, int searchElement, int left, int right)
	{
		if (left == right)
		{
			return array[left].CompareTo(searchElement) == 0 ? left : AbsentResult;
		}

		var position = left + (searchElement - array[left]) * (right - left) / (array[right] - array[left]);

		if (position == array.Count - 1 && array[position].CompareTo(searchElement) != 0)
		{
			return AbsentResult;
		}

		if (position > array.Count - 1 || (position == 0 && array[position].CompareTo(searchElement) != 0))
		{
			return AbsentResult;
		}

		return array[position].CompareTo(searchElement) switch
		{
			0 => position,
			< 0 => InterpolatedSearch(array, searchElement, position + 1, right),
			_ => InterpolatedSearch(array, searchElement, left, position - 1)
		};
	}
}