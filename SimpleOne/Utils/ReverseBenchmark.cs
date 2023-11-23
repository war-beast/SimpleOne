using BenchmarkDotNet.Attributes;
using SimpleAlgo.Services.DifferentTesting;

namespace SimpleOne.Utils;

[Config(typeof(AntiVirusFriendlyConfig))]
[MemoryDiagnoser(true)]
public class ReverseBenchmark
{
	private readonly ReversingService _reversingService;
	public ReverseBenchmark()
	{
		_reversingService = new ReversingService();
	}

	public record ClassPair(IEnumerable<TestUser> Source, int Count)
	{
		public override string ToString()
		{
			return $"{Count} классов";
		}
	}

	public record StructPair(IEnumerable<StructUser> Source, int Count){
		public override string ToString()
		{
			return $"{Count} структур";
		}
	}

	public IEnumerable<ClassPair> Arrays()
	{
		yield return new ClassPair(GetUsers(100), 100);
		yield return new ClassPair(GetUsers(10000), 10000);
	}

	public IEnumerable<StructPair> StructArrays()
	{
		yield return new StructPair(GetStructUsers(100), 100);
		yield return new StructPair(GetStructUsers(10000), 10000);
	}

	private static IEnumerable<TestUser> GetUsers(int count)
	{
		for (int idx = 0; idx < count; idx++)
		{
			yield return new TestUser($"user: {idx}", idx);
		}
	}

	private static IEnumerable<StructUser> GetStructUsers(int count)
	{
		for (int idx = 0; idx < count; idx++)
		{
			yield return new StructUser($"user: {idx}", idx);
		}
	}

	[Benchmark(Description = "Метод IEnumerable.Reverse()")]
	[ArgumentsSource(nameof(Arrays))]
	public void NativeReverse(ClassPair pair)
	{
		_ = _reversingService.ReverseNative(pair.Source).Count();
	}

	[Benchmark(Description = "Исходный реверс из задания")]
	[ArgumentsSource(nameof(Arrays))]
	public void ReverseByList(ClassPair pair)
	{
		_ = _reversingService.ReverseByList(pair.Source).Count();
	}

	[Benchmark(Description = "Реверс с использованием стека")]
	[ArgumentsSource(nameof(Arrays))]
	public void ReverseByStack(ClassPair pair)
	{
		_ = _reversingService.ReverseByStack(pair.Source).Count();
	}

	[Benchmark(Description = "Реверс преобразованием в массив")]
	[ArgumentsSource(nameof(Arrays))]
	public void ReverseByArray(ClassPair pair)
	{
		_ = _reversingService.ReverseByArray(pair.Source).Count();
	}

	[Benchmark(Description = "Реверс c использованием связанного списка")]
	[ArgumentsSource(nameof(Arrays))]
	public void ReverseByLinkedList(ClassPair pair)
	{
		_ = _reversingService.ReverseByLinkedList(pair.Source).Count();
	}

	[Benchmark(Description = "Метод IEnumerable.Reverse()")]
	[ArgumentsSource(nameof(StructArrays))]
	public void NativeReverse(StructPair pair)
	{
		_ = _reversingService.ReverseNative(pair.Source).Count();
	}

	[Benchmark(Description = "Исходный реверс из задания")]
	[ArgumentsSource(nameof(StructArrays))]
	public void ReverseByList(StructPair pair)
	{
		_ = _reversingService.ReverseByList(pair.Source).Count();
	}

	[Benchmark(Description = "Реверс с использованием стека")]
	[ArgumentsSource(nameof(StructArrays))]
	public void ReverseByStack(StructPair pair)
	{
		_ = _reversingService.ReverseByStack(pair.Source).Count();
	}

	[Benchmark(Description = "Реверс преобразованием в массив")]
	[ArgumentsSource(nameof(StructArrays))]
	public void ReverseByArrayStruct(StructPair pair)
	{
		_ = _reversingService.ReverseByArray(pair.Source).Count();
	}

	[Benchmark(Description = "Реверс c использованием связанного списка")]
	[ArgumentsSource(nameof(StructArrays))]
	public void ReverseByLinkedList(StructPair pair)
	{
		_ = _reversingService.ReverseByLinkedList(pair.Source).Count();
	}
}