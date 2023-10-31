using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.SearchingAlgorithms;

public interface ISearchingAlgorithmsService<in T> where T : IComparable<T>
{
	public Result<int> Find(SearchTypes type, T[] array, T searchElement);
}