using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class CrossoverBuilder : CarBuilderBase, ICarBuilder
{
	public CrossoverBuilder() : base(BuilderTypes.Crossover)
	{
	}

	public BuilderTypes BuilderType => BuilderTypes.Crossover;

	public void BuildBody()
	{
		Car.AddPart("Усиленный стальной кузов с интегрированной рамой");
	}

	public void BuildTransmission()
	{
		Car.AddPart("Механическая КПП, передний привод, подключаемый задний привод.");
	}

	public void BuildEngine()
	{
		Car.AddPart("2-хлитровый дизельный двигатель с турбиной");
	}
}