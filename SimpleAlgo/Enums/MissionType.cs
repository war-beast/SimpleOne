using System.ComponentModel;

namespace SimpleAlgo.Enums;

public enum MissionType
{
	[Description("Планетарная миссия")]
	Planet,

	[Description("Пустотная миссия")]
	Space,

	[Description("Орбитальная миссия")]
	Orbit
}