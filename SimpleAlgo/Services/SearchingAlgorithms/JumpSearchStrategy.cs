using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public class JumpSearchStrategy<T> : SearchingStrategyBase<T>, IJumpSearchStrategy<T> where T : IComparable<T>
{
	public override int Find(T[] array, T searchElement)
	{
		if (array.Length == 0)
		{
			return AbsentResult;
		}

		var jumpLength = (int)Math.Sqrt(array.Length);
		return JumpSearchStrategy<T>.JumpSearch(array, searchElement, jumpLength);
	}

	private static int JumpSearch(IReadOnlyList<T> array, T searchElement, int jumpLength)
	{
		var partitionEnd = jumpLength;
		var partitionStart = 0;

		while (array.Count - 1 > partitionEnd)
		{
			if (array[partitionEnd].CompareTo(searchElement) == 0)
			{
				return partitionEnd;
			}

			if (array[partitionEnd].CompareTo(searchElement) < 0)
			{
				partitionStart = partitionEnd;
				partitionEnd += jumpLength;
			}
			else
			{
				break;
			}
		}
		
		return LinearSearch(array, partitionStart, partitionEnd, searchElement);
	}
}