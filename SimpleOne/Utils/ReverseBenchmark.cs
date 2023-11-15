using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using static SimpleOne.Utils.SearchAlgorithmsBenchmark;

namespace SimpleOne.Utils;

[Config(typeof(AntiVirusFriendlyConfig))]
[MemoryDiagnoser(true)]
public class ReverseBenchmark
{
	public IEnumerable<IEnumerable<int>> Arrays()
	{
		yield return Enumerable.Range(0, 100);
		yield return Enumerable.Range(0, 10000);
	}

	[Benchmark(Description = "Метод Array.Reverse()")]
	[ArgumentsSource(nameof(Arrays))]
	public int[] NativeArrayReverse(IEnumerable<int> array)
	{
		var arr = array.ToArray();
		Array.Reverse(arr);

		return arr;
	}

	[Benchmark(Description = "Реверс добавлением пустого массива")]
	[ArgumentsSource(nameof(Arrays))]
	public int[] ReverseByNewArray(IEnumerable<int> array)
	{
		var count = array.Count();

		var myArray = new int[count];
		var idx = count - 1;

		foreach (var item in array)
		{
			myArray[idx--] = item;
		}

		return myArray;
	}

	[Benchmark(Description = "Реверс c использованием связанного списка")]
	[ArgumentsSource(nameof(Arrays))]
	public LinkedList<int> ReverseByLinkedList(IEnumerable<int> array)
	{
		var list = new LinkedList<int>();

		foreach (var item in array)
		{
			list.AddFirst(item);
		}

		return list;
	}
}