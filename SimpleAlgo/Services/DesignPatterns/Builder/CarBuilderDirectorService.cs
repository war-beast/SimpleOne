using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.Builder;
using SimpleAlgo.Models;

namespace SimpleAlgo.Services.DesignPatterns.Builder;

public class CarBuilderDirectorService : ICarBuilderDirectorService
{
	private readonly ICarBuilderFactory _carBuilderFactory;

	public CarBuilderDirectorService(ICarBuilderFactory carBuilderFactory)
	{
		_carBuilderFactory = carBuilderFactory;
	}

	public Result<string> BuildCar(BuilderTypes type)
	{
		try
		{
			var car = _carBuilderFactory.Create(type);
			car.BuildBody();
			car.BuildEngine();
			car.BuildTransmission();
			return Result.Success(car.Build().ShowMe());
		}
		catch (Exception ex)
		{
			return Result.Failure<string>(ex.Message);
		}
	}
}