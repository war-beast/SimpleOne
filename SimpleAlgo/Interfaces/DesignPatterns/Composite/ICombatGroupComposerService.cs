using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.DesignPatterns.Composite;

public interface ICombatGroupComposerService
{
	Result<string> Compose(SubdivisionTypes? type);
}