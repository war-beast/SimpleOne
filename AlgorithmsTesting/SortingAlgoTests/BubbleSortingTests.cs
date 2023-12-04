using AutoFixture;
using SimpleAlgo.Services.SortingAlgorithms;

namespace AlgorithmsTesting.SortingAlgoTests
{
	public class BubbleSortingTests
	{
		[Fact]
		public void EmptyArrayTest()
		{
			var fixture = new Fixture();
			var service = fixture.Create<BubbleSortingStrategy<int>>();

			var array = Array.Empty<int>();
			var result = service.Sort(array);

			Assert.Equal(array, result);
		}

		[Fact]
		public void OneElementArrayTest()
		{
			var fixture = new Fixture();
			var service = fixture.Create<BubbleSortingStrategy<int>>();

			int[] array = { 5 };
			var result = service.Sort(array);

			Assert.Equal(array, result);
		}



		[Fact]
		public void SimmetricArrayTest()
		{
			var fixture = new Fixture();
			var service = fixture.Create<BubbleSortingStrategy<int>>();

			int[] array = { 5, 4, 3, 2, 1, 0, -1, -2, -1, 0, 1, 2, 3, 4, 5 };
			int[] standardSorted = (int[])array.Clone();
			Array.Sort(standardSorted);

			var result = service.Sort(array);

			Assert.Equal(array, result);
		}
	}
}