using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.SortingAlgorithms;

public interface IAlgorithmsService<T> where T : IComparable<T>
{
	Result<T[]> GetSortResult(SortTypes sortType, T[] array);
}