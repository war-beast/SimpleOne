using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class CarFluentBuilderFactory : IFluentCarBuilderFactory
{
	private readonly Dictionary<BuilderTypes, IFluentCarBuilder> _carBuilders;

	public CarFluentBuilderFactory(IEnumerable<IFluentCarBuilder> builders)
	{
		_carBuilders = builders.ToDictionary(k => k.BuilderType, v => v);
	}

	public IFluentCarBuilder Create(BuilderTypes type)
	{
		if (_carBuilders.TryGetValue(type, out var carBuilder))
		{
			return carBuilder;
		}

		throw new ArgumentException("Попытка выпустить неизвествный тип автомобиля");
	}
}