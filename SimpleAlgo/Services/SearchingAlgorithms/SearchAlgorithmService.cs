using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.SearchingAlgorithms;
using SimpleAlgo.Models;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class SearchAlgorithmService<T> : ISearchingAlgorithmsService<T> where T : IComparable<T>
{
	private readonly ISearchAlgoFactory<T> _searchAlgoFactory;

	public SearchAlgorithmService(ISearchAlgoFactory<T> searchAlgoFactory)
	{
		_searchAlgoFactory = searchAlgoFactory;
	}

	public Result<int> Find(SearchTypes type, T[] array, T searchElement)
	{
		try
		{
			var searchingStrategy = _searchAlgoFactory.Create(type);
			return Result.Success(searchingStrategy.Find(array, searchElement));
		}
		catch (ArgumentException exc)
		{
			return Result.Failure<int>(exc.Message);
		}
	}
}