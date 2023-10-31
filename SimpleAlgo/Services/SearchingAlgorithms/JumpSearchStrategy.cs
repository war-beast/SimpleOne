using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class JumpSearchStrategy<T> : SearchingStrategyBase<T>, IJumpSearchStrategy<T> where T : IComparable<T>
{
	public override int Find(T[] array, T searchElement)
	{
		throw new NotImplementedException();
	}
}