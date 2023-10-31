using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface ISearchingAlgorithmsService<T>
{
	public Result<T> Find(SearchTypes type, T[] array, T searchElement);
}