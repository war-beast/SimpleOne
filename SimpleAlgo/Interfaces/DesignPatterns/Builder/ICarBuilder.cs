using SimpleAlgo.Enums;
using SimpleAlgo.Models.DesignPatterns.Builder;

namespace SimpleAlgo.Interfaces.DesignPatterns.Builder;

public interface ICarBuilder
{
	BuilderTypes BuilderType { get; }

	void BuildBody();
	void BuildTransmission();
	void BuildEngine();
	Car Build();
}