﻿using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.SearchingAlgorithms;
using SimpleAlgo.Interfaces.SortingAlgorithms;
using SimpleOne.Models;

namespace SimpleOne.Controllers;

[Route("search")]
public class SearchingAlgorithmController : Controller
{
	private readonly IAlgorithmsService<int> _algorithmsService;
	private readonly ISearchingAlgorithmsService<int> _searchingAlgorithmsService;

	public SearchingAlgorithmController(ISearchingAlgorithmsService<int> searchingAlgorithmsService,
		IAlgorithmsService<int> algorithmsService)
	{
		_searchingAlgorithmsService = searchingAlgorithmsService;
		_algorithmsService = algorithmsService;
	}

	/// <summary>
	/// Бинарный поиск
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("binary")]
	public IActionResult SearchBinary([FromBody] IntegerSearchRequest request)
	{
		#region Поиск работает только по отсортированному массиву

		var sortedArrayResult = _algorithmsService.GetSortResult(SortTypes.InsertionSort, request.Array);
		if (sortedArrayResult.IsFailure)
		{
			BadRequest(sortedArrayResult.Error);
		}

		#endregion

		var result = _searchingAlgorithmsService.Find(SearchTypes.Binary, sortedArrayResult.Data, request.Element);

		return result.IsSuccess 
			? Ok(result.Data) 
			: BadRequest(result.Error);
	}

	/// <summary>
	/// Поиск прыжками, он же поиск по переходам (Jump search)
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("jump")]
	public IActionResult SearchByJump([FromBody] IntegerSearchRequest request)
	{
		#region Поиск работает только по отсортированному массиву

		var sortedArrayResult = _algorithmsService.GetSortResult(SortTypes.InsertionSort, request.Array);
		if (sortedArrayResult.IsFailure)
		{
			BadRequest(sortedArrayResult.Error);
		}

		#endregion

		var result = _searchingAlgorithmsService.Find(SearchTypes.Jump, sortedArrayResult.Data, request.Element);

		return result.IsSuccess
			? Ok(result.Data)
			: BadRequest(result.Error);
	}

	/// <summary>
	/// Поиск интерполяцией
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("interpolation")]
	public IActionResult SearchByInterpolation([FromBody] IntegerSearchRequest request)
	{
		#region Поиск работает только по отсортированному массиву

		var sortedArrayResult = _algorithmsService.GetSortResult(SortTypes.InsertionSort, request.Array);
		if (sortedArrayResult.IsFailure)
		{
			BadRequest(sortedArrayResult.Error);
		}

		#endregion

		var result = _searchingAlgorithmsService.Find(SearchTypes.Interpolation, sortedArrayResult.Data, request.Element);

		return result.IsSuccess
			? Ok(result.Data)
			: BadRequest(result.Error);
	}

	/// <summary>
	/// Экспоненциальный поиск
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("exponential")]
	public IActionResult SearchByExponential([FromBody] IntegerSearchRequest request)
	{
		#region Поиск работает только по отсортированному массиву

		var sortedArrayResult = _algorithmsService.GetSortResult(SortTypes.InsertionSort, request.Array);
		if (sortedArrayResult.IsFailure)
		{
			BadRequest(sortedArrayResult.Error);
		}

		#endregion

		var result = _searchingAlgorithmsService.Find(SearchTypes.Exponential, sortedArrayResult.Data, request.Element);

		return result.IsSuccess
			? Ok(result.Data)
			: BadRequest(result.Error);
	}
}