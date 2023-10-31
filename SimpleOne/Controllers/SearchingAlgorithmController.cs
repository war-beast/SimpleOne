using Microsoft.AspNetCore.Mvc;
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
		#region Бинарный поиск работает только по отсортированному массиву

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
}