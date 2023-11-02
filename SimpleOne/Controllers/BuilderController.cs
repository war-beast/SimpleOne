using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;

namespace SimpleOne.Controllers;

[ApiController]
[Route("pattern")]
public class BuilderController : Controller
{
	private readonly ICarBuilderDirectorService _carBuilderDirectorService;

	public BuilderController(ICarBuilderDirectorService carBuilderDirectorService)
	{
		_carBuilderDirectorService = carBuilderDirectorService;
	}

	/// <summary>
	/// Реализация паттеран Строитель
	/// </summary>
	/// <param name="type"></param>
	/// <returns></returns>
	[HttpGet("builder/{type:int}")]
	public IActionResult Builder(BuilderTypes type)
	{
		var result = _carBuilderDirectorService.BuildCar(type);
		
		return result.IsSuccess 
			? Ok(result.Data) 
			: BadRequest(result.Error);
	}

	/// <summary>
	/// Получение списка всех типов Строителей
	/// </summary>
	/// <returns></returns>
	[HttpGet("builder/types")]
	public IActionResult GetBuilderTypes()
	{
		var builderTypes = Enum.GetValues(typeof(BuilderTypes))
			.Cast<BuilderTypes>()
			.ToDictionary(k => (int)k, v => v.GetEnumDescription());

		return Ok(builderTypes);
	}
}