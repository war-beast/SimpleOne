using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class SearchAlgoFactory<T> : ISearchAlgoFactory<T>
{
	private readonly Dictionary<SearchTypes, ISearchAlgorithm<T>> _algorithms = new();

	public SearchAlgoFactory()
	{
		//_algorithms.Add(
		//	{ SearchTypes.Binary,  }
		//);
	}

	public ISearchAlgorithm<T> Create(SearchTypes type)
	{
		throw new NotImplementedException();
	}
}