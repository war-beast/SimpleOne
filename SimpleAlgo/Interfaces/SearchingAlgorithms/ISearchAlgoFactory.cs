using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface ISearchAlgoFactory<in T> where T : IComparable<T>
{
	ISearchAlgorithm<T> Create(SearchTypes type);
}