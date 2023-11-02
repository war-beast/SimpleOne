using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Models.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class CarFluentBuilderBase
{
	protected Car Car { get; }

	protected CarFluentBuilderBase(BuilderTypes type)
	{
		Car = new Car(type.GetEnumDescription());
	}

	public Car Build() => Car;
}