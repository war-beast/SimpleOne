using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class BinarySearchStrategy<T> : SearchingStrategyBase<T>, IBinarySearchStrategy<T>
{
	public override T Find(T[] array, T searchElement)
	{
		throw new NotImplementedException();
	}
}