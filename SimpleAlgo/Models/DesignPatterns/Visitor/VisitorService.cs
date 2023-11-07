using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Visitor;
using System;
using System.Text;
using SimpleAlgo.Services.DesignPatterns.Visitor;

namespace SimpleAlgo.Models.DesignPatterns.Visitor;

public class VisitorService : IVisitorService
{
	private readonly IEnumerable<IShipWeaponContainable> _ships;
	private readonly IWeaponTunerDispatcher _weaponTunerDispatcher;

	public VisitorService(IEnumerable<IShipWeaponContainable> ships, IWeaponTunerDispatcher weaponTunerDispatcher)
	{
		_ships = ships;
		_weaponTunerDispatcher = weaponTunerDispatcher;
	}

	public Result<string> TuneShips(IReadOnlyList<BattleShipType> types)
	{
		var validationResult = ValidateRequest(types);
		if (validationResult.IsFailure)
		{
			return validationResult;
		}

		SelectVisitingShips(types);

		//Для простоты экземпляры конкретных посетителей получим через new()
		StringBuilder sb = new();
		sb.AppendLine("----Настройка курсового вооружения----");
		sb.AppendLine(_weaponTunerDispatcher.TuneWeapon(new ForwardWeaponTuningVisitor()));
		sb.AppendLine("----Настройка подвесного вооружения----");
		sb.AppendLine(_weaponTunerDispatcher.TuneWeapon(new SuspendedWeaponTuningVisitor()));

		return Result.Success(sb.ToString());
	}

	#region Private methods

	private static Result<string> ValidateRequest(IReadOnlyCollection<BattleShipType> types)
	{
		if (types.Count == 0)
		{
			{
				return Result.Failure<string>("Не выбраны типы кораблей для настройки вооружения.");
			}
		}

		var accessibleTypes = Enum.GetValues(typeof(BattleShipType))
			.Cast<BattleShipType>();
		if (!types.All(x => accessibleTypes.Contains(x)))
		{
			{
				return Result.Failure<string>("В запросе указаны неизвестные типы кораблей.");
			}
		}

		return Result.Success(string.Empty);
	}

	private void SelectVisitingShips(IReadOnlyList<BattleShipType> types)
	{
		var selectedShips = _ships.Where(x => types.Contains(x.Type));
		foreach (var ship in selectedShips)
		{
			_weaponTunerDispatcher.Add(ship);
		}
	}

	#endregion
}