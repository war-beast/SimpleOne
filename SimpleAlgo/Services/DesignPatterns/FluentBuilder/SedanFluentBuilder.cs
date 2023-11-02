using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class SedanFluentBuilder : CarFluentBuilderBase, IFluentCarBuilder
{
	public SedanFluentBuilder() : base(BuilderTypes.Sedan)
	{
		
	}

	public BuilderTypes BuilderType => BuilderTypes.Sedan;

	public IFluentCarBuilder BuildBody()
	{
		Car.AddPart("Стальной кузов на лонжеронах.");
		return this;
	}

	public IFluentCarBuilder BuildTransmission()
	{
		Car.AddPart("Автоматическая КПП с передним приводом");
		return this;
	}

	public IFluentCarBuilder BuildEngine()
	{
		Car.AddPart("Атмосферный 1,5 литровый бензиновый двигатель");
		return this;
	}
}