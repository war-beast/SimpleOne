using BenchmarkDotNet.Attributes;
using SimpleAlgo.Interfaces.SearchingAlgorithms;
using SimpleAlgo.Services.SearchingAlgorithms;

namespace SimpleOne.Utils;

[Config(typeof(AntiVirusFriendlyConfig))]
[MemoryDiagnoser(true)]
public class SearchAlgorithmsBenchmark
{
	private readonly IBinarySearchStrategy<int> _binarySearchStrategy;
	private readonly IJumpSearchStrategy<int> _jumpSearchStrategy;
	private readonly IInterpolatedSearchStrategy<int> _interpolatedSearchStrategy;
	private readonly IExponentialSearchStrategy<int> _exponentialSearchStrategy;

	public record SearchPair(int[] Array, int ToFind)
	{
		public override string ToString()
		{
			return $"{Array.Length} чисел. Найти: {ToFind}";
		}
	}

	public IEnumerable<SearchPair> Arrays()
	{
		yield return new SearchPair(new[]
			{ -5, -4, -1, 0, 1, 2, 3, 5, 6, 9, 11, 13, 14, 15, 17, 19, 20, 23, 25, 27, 29, 31, 34, 35, 37, 39 }, 27);
		yield return new SearchPair(Enumerable.Range(-10, 100).ToArray(), 89);
	}

	public SearchAlgorithmsBenchmark()
	{
		_binarySearchStrategy = new BinarySearchStrategy<int>();
		_jumpSearchStrategy = new JumpSearchStrategy<int>();
		_interpolatedSearchStrategy = new InterpolatedSearchStrategy<int>();
		_exponentialSearchStrategy = new ExponentialSearchStrategy<int>();
	}

	[Benchmark(Description = "Линейный поиск")]
	[ArgumentsSource(nameof(Arrays))]
	public void TestArrayNativeSearch(SearchPair pair)
	{
		foreach (var t in pair.Array)
		{
			if (t == pair.ToFind)
				break;
		}
	}

	[Benchmark(Description = "Бинарный поиск")]
	[ArgumentsSource(nameof(Arrays))]
	public void TestArrayBinarySearch(SearchPair pair)
	{
		_binarySearchStrategy.Find(pair.Array, pair.ToFind);
	}

	[Benchmark(Description = "Поиск переходами")]
	[ArgumentsSource(nameof(Arrays))]
	public void TestArrayJumpSearch(SearchPair pair)
	{
		_jumpSearchStrategy.Find(pair.Array, pair.ToFind);
	}

	[Benchmark(Description = "Поиск интерполяцией")]
	[ArgumentsSource(nameof(Arrays))]
	public void TestArrayInterpolationSearch(SearchPair pair)
	{
		_interpolatedSearchStrategy.Find(pair.Array, pair.ToFind);
	}

	[Benchmark(Description = "Экспонентный поиск")]
	[ArgumentsSource(nameof(Arrays))]
	public void TestArrayExponentialSearch(SearchPair pair)
	{
		_exponentialSearchStrategy.Find(pair.Array, pair.ToFind);
	}
}