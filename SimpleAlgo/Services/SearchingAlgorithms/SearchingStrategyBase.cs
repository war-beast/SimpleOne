﻿using SimpleAlgo.Interfaces.SearchingAlgorithms;

namespace SimpleAlgo.Services.SearchingAlgorithms;

public abstract class SearchingStrategyBase<T> : ISearchAlgorithm<T> where T : IComparable<T>
{
	protected const int AbsentResult = -1;

	public abstract int Find(T[] array, T searchElement);
}