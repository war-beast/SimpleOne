using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class InterpolatedSearchStrategy<T> : SearchingStrategyBase<T>, IInterpolatedSearchStrategy<T> where T : IComparable<T>
{
	public override int Find(T[] array, T searchElement)
	{
		return array.Length  == 0 
			? AbsentResult
			: InterpolatedSearch(array, searchElement, 0, array.Length - 1);
	}

	private static int InterpolatedSearch(T[] array, T searchElement, int left, int right)
	{
		throw new NotImplementedException();
	}
}