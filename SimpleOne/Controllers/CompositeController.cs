using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Composite;

namespace SimpleOne.Controllers;

[ApiController]
[Route("pattern")]
public class CompositeController : ControllerBase
{
	private readonly ICombatGroupComposerService _composerService;

	public CompositeController(ICombatGroupComposerService composerService)
	{
		_composerService = composerService;
	}

	/// <summary>
	/// Реализация паттерна Компоновщик
	/// </summary>
	/// <param name="type"></param>
	/// <returns></returns>
	[HttpGet("composite/{type:int?}")]
	public IActionResult StartVisit(SubdivisionTypes? type)
	{
		var result = _composerService.Compose(type);

		return result.IsSuccess
			? Ok(result.Data)
			: BadRequest(result.Error);
	}
}