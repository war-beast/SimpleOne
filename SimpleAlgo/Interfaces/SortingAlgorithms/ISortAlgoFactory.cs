using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.SortingAlgorithms;

public interface ISortAlgoFactory<T> where T : IComparable<T>
{
	ISortAlgorithm<T> Create(SortTypes sortType);
}