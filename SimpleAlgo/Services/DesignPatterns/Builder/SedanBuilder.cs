using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class SedanBuilder : CarBuilderBase, ICarBuilder
{
	public SedanBuilder() : base(BuilderTypes.Sedan)
	{
		
	}

	public BuilderTypes BuilderType => BuilderTypes.Sedan;

	public void BuildBody()
	{
		Car.AddPart("Стальной кузов на лонжеронах.");
	}

	public void BuildTransmission()
	{
		Car.AddPart("Автоматическая КПП с передним приводом");
	}

	public void BuildEngine()
	{
		Car.AddPart("Атмосферный 1,5 литровый бензиновый двигатель");
	}
}