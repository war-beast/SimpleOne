using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class MilitaryCarBuilder : CarBuilderBase, ICarBuilder
{
	public MilitaryCarBuilder() : base(BuilderTypes.Military)
	{
	}

	public BuilderTypes BuilderType => BuilderTypes.Military; 
	
	public void BuildBody()
	{
		Car.AddPart("Бронированный рамный кузов");
	}

	public void BuildTransmission()
	{
		Car.AddPart("Постоянный полный привод с механической КПП и вакуумной подвеской");
	}

	public void BuildEngine()
	{
		Car.AddPart("Атмосферный дизельный 3-хлитровый двигатель.");
	}
}