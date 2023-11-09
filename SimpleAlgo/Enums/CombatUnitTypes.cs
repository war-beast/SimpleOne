using System.ComponentModel;

namespace SimpleAlgo.Enums;

public enum CombatUnitTypes
{
	[Description("Эскадрилья")]
	Escadrille,

	[Description("Одиночный рейдер")]
	SoloRaider,

	[Description("Пилот")]
	Pilot,

	[Description("Штурмовик (человек/робот)")]
	Stormtrooper
}