using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class BuggyFluentBuilder : CarFluentBuilderBase, IFluentCarBuilder
{
	public BuggyFluentBuilder() : base(BuilderTypes.Buggy)
	{
	}

	public BuilderTypes BuilderType => BuilderTypes.Buggy;

	public IFluentCarBuilder BuildBody()
	{
		Car.AddPart("Вместо кузова конструкция из сваренных труб");
		return this;
	}

	public IFluentCarBuilder BuildTransmission()
	{
		Car.AddPart("Постоянный полный привод с механической КПП и динамической подвеской");
		return this;
	}

	public IFluentCarBuilder BuildEngine()
	{
		Car.AddPart("Атмосферный дизельный двигатель от трактора");
		return this;
	}
}