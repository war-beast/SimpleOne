using System.ComponentModel;

namespace SimpleAlgo.Enums;

public enum SubdivisionTypes
{
	[Description("Эскадра")]
	Squadron = 1,

	[Description("Разведывательный рейд")]
	ReconnaissanceRaid = 2,

	[Description("Диверсионная группа")]
	SabotageGroup = 3
}