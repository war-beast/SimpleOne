namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface IExponentialSearchStrategy<in T> : ISearchAlgorithm<T> where T : IComparable<T>
{
	
}