using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgo.Services.DifferentTesting;

public class ReversingService
{
	/// <summary>
	/// Эталон
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="source"></param>
	/// <returns></returns>
	public IEnumerable<T> ReverseNative<T>(IEnumerable<T> source)
	{

		return source.Reverse();
	}

	/// <summary>
	/// Реверс из постановки задачи
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="source"></param>
	/// <returns></returns>
	public IEnumerable<T> ReverseByList<T>(IEnumerable<T> source)
	{
		var list = new List<T>();

		foreach (var item in source)
		{
			list.Insert(0, item);
		}

		return list;
	}

	/// <summary>
	/// Реверс со стеком вместо списка
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="source"></param>
	/// <returns></returns>
	public IEnumerable<T> ReverseByStack<T>(IEnumerable<T> source)
	{
		var list = new Stack<T>();

		foreach (var item in source)
		{
			list.Push(item);
		}

		return list;
	}

	/// <summary>
	/// Реверс на основе связанного списка
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="source"></param>
	/// <returns></returns>
	public IEnumerable<T> ReverseByLinkedList<T>(IEnumerable<T> source)
	{
		var list = new LinkedList<T>();

		foreach (var item in source)
		{
			list.AddFirst(item);
		}

		return list;
	}

	/// <summary>
	/// То, как я предложил
	/// </summary>
	/// <param name="array"></param>
	/// <returns></returns>
	public IEnumerable<T> ReverseByArray<T>(IEnumerable<T> source)
	{
		var array = source.ToArray();

		for (var idx = array.Length - 1; idx >= 0; idx--)
		{
			yield return array[idx];
		}
	}
}

public record TestUser(string Name, int IQ);

public record struct StructUser(string Name, int IQ);