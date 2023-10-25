using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces;
using SimpleOne.Models;

namespace SimpleOne.Controllers;

[Route("algo")]
public class SortingAlgorithmController : Controller
{
	private readonly IAlgorithmsService<int> _algorithmsService;

	public SortingAlgorithmController(IAlgorithmsService<int> algorithmsService)
	{
		_algorithmsService = algorithmsService;
	}

	/// <summary>
	/// Сортировка пузырьком
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("bubbleInt")]
	public IActionResult BubbleSort([FromBody] IntegerSortingRequest request)
	{
		var result = _algorithmsService.GetSortResult(SortTypes.BubbleSort, request.Values);
		if (result.IsFailure)
		{
			return BadRequest(result.Error);
		}

		return Ok(result.Data);
	}

	/// <summary>
	/// Коктейльная сортировка
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("shakerInt")]
	public IActionResult ShakerSort([FromBody] IntegerSortingRequest request)
	{
		var result = _algorithmsService.GetSortResult(SortTypes.ShakerSort, request.Values);

		if (result.IsFailure)
		{
			return BadRequest(result.Error);
		}

		return Ok(result.Data);
	}

	/// <summary>
	/// Сортировка расчёской
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("combInt")]
	public IActionResult CombSort([FromBody] IntegerSortingRequest request)
	{
		var result = _algorithmsService.GetSortResult(SortTypes.CombSort, request.Values);

		if (result.IsFailure)
		{
			return BadRequest(result.Error);
		}

		return Ok(result.Data);
	}

	/// <summary>
	/// Сортировка вставками
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	[HttpPost("insertInt")]
	public IActionResult InsertionSort([FromBody] IntegerSortingRequest request)
	{
		var result = _algorithmsService.GetSortResult(SortTypes.InsertionSort, request.Values);

		if (result.IsFailure)
		{
			return BadRequest(result.Error);
		}

		return Ok(result.Data);
	}
}