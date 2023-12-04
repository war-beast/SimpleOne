using AlgorithmsTesting.Attributes;
using SimpleAlgo.Enums;
using SimpleAlgo.Services.SortingAlgorithms;

namespace AlgorithmsTesting.SortingAlgoTests;

public class SortingServiceTests
{
	[Theory, DefaultAutoData]
	public void DifferentAlgosTest(AlgorithmsService<int> service)
	{
		int[] array_1 = { 5, 4, 3, 2, 1, 0, -1, -2, -1, 0, 1, 2, 3, 4, 5 };
		int[] array_2 = { 5, 4, 3, 2, 1, 0, -1, -2, -1, 0, 1, 2, 3, 4, 5 };

		var bubbleResult = service.GetSortResult(SortTypes.BubbleSort, array_1);
		var insertionSort = service.GetSortResult(SortTypes.InsertionSort, array_2);

		Assert.Equal(insertionSort.Data, bubbleResult.Data);
	}
}