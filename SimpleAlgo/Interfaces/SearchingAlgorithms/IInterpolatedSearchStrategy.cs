namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface IInterpolatedSearchStrategy<in T> : ISearchAlgorithm<T> where T : IComparable<T>
{
	
}