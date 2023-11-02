using SimpleAlgo.Enums;
using SimpleAlgo.Models;

namespace SimpleAlgo.Interfaces.DesignPatterns.Builder;

public interface ICarBuilderDirectorService
{
	Result<string> BuildCar(BuilderTypes type);
}