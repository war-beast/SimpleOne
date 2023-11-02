using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class CarBuilderFactory : ICarBuilderFactory
{
	private readonly Dictionary<BuilderTypes, ICarBuilder> _carBuilders;

	public CarBuilderFactory(IEnumerable<ICarBuilder> builders)
	{
		_carBuilders = builders.ToDictionary(k => k.BuilderType, v => v);
	}

	public ICarBuilder Create(BuilderTypes type)
	{
		if (_carBuilders.TryGetValue(type, out var carBuilder))
		{
			return carBuilder;
		}

		throw new ArgumentException("Попытка выпустить неизвествный тип автомобиля");
	}
}