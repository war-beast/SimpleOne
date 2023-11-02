using SimpleAlgo.Enums;
using SimpleAlgo.Extensions;
using SimpleAlgo.Models.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class CarBuilderBase
{
	protected Car Car { get; }

	protected CarBuilderBase(BuilderTypes type)
	{
		Car = new Car(type.GetEnumDescription());
	}

	public Car Build() => Car;
}