using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class ExponentialSearchStrategy<T> : SearchingStrategyBase<T>, IExponentialSearchStrategy<T> where T : IComparable<T>
{
	public override int Find(T[] array, T searchElement)
	{
		throw new NotImplementedException();
	}
}