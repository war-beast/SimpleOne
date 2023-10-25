using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces;

namespace SimpleOne.Controllers;

[Route("algo")]
public class SortingAlgorithmController : Controller
{
	private readonly IAlgorithmsService<int> _algorithmsService;

	public SortingAlgorithmController(IAlgorithmsService<int> algorithmsService)
	{
		_algorithmsService = algorithmsService;
	}

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
}