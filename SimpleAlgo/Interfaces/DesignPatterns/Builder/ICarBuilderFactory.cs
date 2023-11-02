using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.DesignPatterns.Builder;

public interface ICarBuilderFactory
{
	ICarBuilder Create(BuilderTypes type);
}