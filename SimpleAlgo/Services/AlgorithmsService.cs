﻿using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces;
using SimpleAlgo.Models;

namespace SimpleAlgo.Services;

public class AlgorithmsService<T> : IAlgorithmsService<T> where T : IComparable<T>
{
	private readonly ISortAlgoFactory<T> _sortAlgoFactory;

	public AlgorithmsService(ISortAlgoFactory<T> sortAlgoFactory)
	{
		_sortAlgoFactory = sortAlgoFactory;
	}

	public Result<T[]> GetSortResult(SortTypes sortType, T[] array)
	{
		try
		{
			var sortAlgo = _sortAlgoFactory.Create(sortType);
			return Result.Success(sortAlgo.Sort(array));
		}
		catch (Exception e)
		{
			return Result.Failure<T[]>(e.Message);
		}
	}
}