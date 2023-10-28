using BenchmarkDotNet.Attributes;
using SimpleAlgo.Interfaces;
using SimpleAlgo.Services;

namespace SimpleOne.Utils;

[Config(typeof(AntiVirusFriendlyConfig))]
[MemoryDiagnoser(true)]
public class AlgorithmsBenchmark
{
	private readonly IBubbleSortingStrategy<int> _bubbleSortingStrategy;
	private readonly IShakerSortingStrategy<int> _shakerSortingStrategy;
	private readonly ICombSortStrategy<int> _combSortStrategy;
	private readonly IInsertionSortingStrategy<int> _insertionSortingStrategy;
	private readonly IQuickSortingStrategy<int> _quickSortingStrategy;
	private readonly IMergeSortingStrategy<int> _mergeSortingStrategy;

	static Random randNum = new ();

	public IEnumerable<IEnumerable<int>> Arrays()
	{
		yield return Enumerable
			.Repeat(0, 100)
			.Select(i => randNum.Next(-100, 100))
			.ToArray();
		yield return Enumerable
			.Repeat(0, 1000)
			.Select(i => randNum.Next(-100, 100))
			.ToArray();
	} 

	public AlgorithmsBenchmark()
	{
		_bubbleSortingStrategy = new BubbleSortingStrategy<int>();
		_shakerSortingStrategy = new ShakerSortingStrategy<int>();
		_combSortStrategy = new CombSortStrategy<int>();
		_insertionSortingStrategy = new InsertionSortingStrategy<int>();
		_quickSortingStrategy = new QuickSortingStrategy<int>();
		_mergeSortingStrategy = new MergeSortingStrategy<int>();
	}

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestArraySortNative(int[] array) => System.Array.Sort(array);

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestBubble(int[] array)
	{
		_bubbleSortingStrategy.Sort(array);
	}

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestShaker(int[] array)
	{
		_shakerSortingStrategy.Sort(array);
	}

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestComb(int[] array)
	{
		_combSortStrategy.Sort(array);
	}

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestInsertion(int[] array)
	{
		_insertionSortingStrategy.Sort(array);
	}

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestQuick(int[] array)
	{
		_quickSortingStrategy.Sort(array);
	}

	[Benchmark]
	[ArgumentsSource(nameof(Arrays))]
	public void TestMerge(int[] array)
	{
		_mergeSortingStrategy.Sort(array);
	}
}