using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class BuggyBuilder : CarBuilderBase, ICarBuilder
{
	public BuggyBuilder() : base(BuilderTypes.Buggy)
	{
	}

	public BuilderTypes BuilderType => BuilderTypes.Buggy;

	public void BuildBody()
	{
		Car.AddPart("Вместо кузова конструкция из сваренных труб");
	}

	public void BuildTransmission()
	{
		Car.AddPart("Постоянный полный привод с механической КПП и динамической подвеской");
	}

	public void BuildEngine()
	{
		Car.AddPart("Атмосферный дизельный двигатель от трактора");
	}
}