using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface ISearchAlgoFactory<T>
{
	ISearchAlgorithm<T> Create(SearchTypes type);
}