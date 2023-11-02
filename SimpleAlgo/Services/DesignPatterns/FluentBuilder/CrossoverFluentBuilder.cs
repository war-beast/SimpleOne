using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class CrossoverFluentBuilder : CarFluentBuilderBase, IFluentCarBuilder
{
	public CrossoverFluentBuilder() : base(BuilderTypes.Crossover)
	{
	}

	public BuilderTypes BuilderType => BuilderTypes.Crossover;

	public IFluentCarBuilder BuildBody()
	{
		Car.AddPart("Усиленный стальной кузов с интегрированной рамой");
		return this;
	}

	public IFluentCarBuilder BuildTransmission()
	{
		Car.AddPart("Механическая КПП, передний привод, подключаемый задний привод.");
		return this;
	}

	public IFluentCarBuilder BuildEngine()
	{
		Car.AddPart("2-хлитровый дизельный двигатель с турбиной");
		return this;
	}
}