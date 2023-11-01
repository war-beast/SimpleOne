using SimpleAlgo.Services.SearchingAlgorithms;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface IInterpolatedSearchStrategy<T> : ISearchAlgorithm<T> where T : IComparable<T>
{

}