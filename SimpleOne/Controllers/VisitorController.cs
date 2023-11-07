using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;

namespace SimpleOne.Controllers;

[ApiController]
[Route("pattern")]
public class VisitorController : ControllerBase
{
	private readonly IVisitorService _visitorService;

	public VisitorController(IVisitorService visitorService)
	{
		_visitorService = visitorService;
	}

	/// <summary>
	/// Реализация паттерна Посетитель
	/// </summary>
	/// <param name="types"></param>
	/// <returns></returns>
	[HttpPost("visitor")]
	public IActionResult StartVisit(IReadOnlyList<BattleShipType> types)
	{
		var result = _visitorService.TuneShips(types);

		return result.IsSuccess 
			? Ok(result.Data) 
			: BadRequest(result.Error);
	}
}