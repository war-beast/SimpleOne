using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class BinarySearchStrategy<T> : SearchingStrategyBase<T>, IBinarySearchStrategy<T> where T : IComparable<T>
{
	public override int Find(T[] array, T searchElement)
	{
		return array.Length == 0 
			? AbsentResult 
			: BinarySearch(array, 0, array.Length - 1, searchElement);
	}
}