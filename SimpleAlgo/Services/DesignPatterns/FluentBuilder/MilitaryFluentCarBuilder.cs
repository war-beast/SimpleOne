using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class MilitaryFluentCarBuilder : CarFluentBuilderBase, IFluentCarBuilder
{
	public MilitaryFluentCarBuilder() : base(BuilderTypes.Military)
	{
	}

	public BuilderTypes BuilderType => BuilderTypes.Military; 
	
	public IFluentCarBuilder BuildBody()
	{
		Car.AddPart("Бронированный рамный кузов");
		return this;
	}

	public IFluentCarBuilder BuildTransmission()
	{
		Car.AddPart("Постоянный полный привод с механической КПП и вакуумной подвеской");
		return this;
	}

	public IFluentCarBuilder BuildEngine()
	{
		Car.AddPart("Атмосферный дизельный 3-хлитровый двигатель.");
		return this;
	}
}