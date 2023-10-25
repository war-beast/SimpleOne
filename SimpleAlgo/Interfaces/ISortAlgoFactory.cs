using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces;

public interface ISortAlgoFactory<T> where T : IComparable<T>
{
	ISortAlgorithm<T> Create(SortTypes sortType);
}