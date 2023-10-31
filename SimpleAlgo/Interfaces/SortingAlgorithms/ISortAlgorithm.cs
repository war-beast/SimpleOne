namespace SimpleAlgo.Interfaces.SortingAlgorithms;

public interface ISortAlgorithm<T> where T : IComparable<T>
{
	T[] Sort(T[] array);
}