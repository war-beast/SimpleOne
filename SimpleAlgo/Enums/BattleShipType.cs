using System.ComponentModel;

namespace SimpleAlgo.Enums;

public enum BattleShipType
{
	[Description("Линкор")]
	BattleShip = 1,

	[Description("Авианосец")]
	Carrier = 2,

	[Description("Истребитель")]
	Fighter = 3
}