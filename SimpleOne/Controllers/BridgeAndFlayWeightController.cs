using Microsoft.AspNetCore.Mvc;
using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Interfaces.DesignPatterns.Bridge;

namespace SimpleOne.Controllers;

[Route("pattern/bridge")]
[ApiController]
public class BridgeAndFlayWeightController : ControllerBase
{
	private readonly IBattleShipsBridgeService _bridgeService;

	public BridgeAndFlayWeightController(IBattleShipsBridgeService bridgeService)
	{
		this._bridgeService = bridgeService;
	}

	[HttpGet("missionType/{type:int}")]
	public IActionResult StartMission(MissionType type)
	{
		var result = _bridgeService.StartMission(type);

		return result.IsSuccess 
			? Ok(result.Data) 
			: BadRequest(result.Error);
	}

	/// <summary>
	/// Получение видов боевых задач для космического флота
	/// </summary>
	/// <returns></returns>
	[HttpGet("missionTypes")]
	public IActionResult GetTypes()
	{
		var missionTypes = Enum.GetValues(typeof(MissionType))
			.Cast<MissionType>()
			.ToDictionary(k => (int)k, v => v.GetEnumDescription());

		return Ok(missionTypes);
	}
}