using System.ComponentModel;

namespace SimpleAlgo.Enums;

public enum BuilderTypes
{
	[Description("Седан")]
	Sedan = 1,

	[Description("Кроссовер")]
	Crossover = 2,

	[Description("Багги")]
	Buggy = 3,

	[Description("Военный")]
	Military = 4
}