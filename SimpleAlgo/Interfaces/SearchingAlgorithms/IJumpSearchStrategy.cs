namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface IJumpSearchStrategy<in T> : ISearchAlgorithm<T> where T : IComparable<T>
{
	
}