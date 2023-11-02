using SimpleAlgo.Enums;
using SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;
using SimpleAlgo.Models;

namespace SimpleAlgo.Services.DesignPatterns.FluentBuilder;

public class CarFluentBuilderDirectorService : IFluentCarBuilderDirectorService
{
	private readonly IFluentCarBuilderFactory _carBuilderFactory;

	public CarFluentBuilderDirectorService(IFluentCarBuilderFactory carBuilderFactory)
	{
		_carBuilderFactory = carBuilderFactory;
	}

	public Result<string> BuildCar(BuilderTypes type)
	{
		try
		{
			var car = _carBuilderFactory.Create(type)
				.BuildBody()
				.BuildEngine()
				.BuildTransmission();

			return Result.Success(car.Build().ShowMe());
		}
		catch (Exception ex)
		{
			return Result.Failure<string>(ex.Message);
		}
	}
}