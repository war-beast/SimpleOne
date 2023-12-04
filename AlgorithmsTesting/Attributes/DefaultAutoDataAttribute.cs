using AlgorithmsTesting.Shared;
using AutoFixture;
using AutoFixture.Xunit2;
using SimpleAlgo.Services.SortingAlgorithms;

namespace AlgorithmsTesting.Attributes;

internal class DefaultAutoDataAttribute : AutoDataAttribute
{
	private static readonly Func<IFixture> FixtureFactory = () => new Fixture().Customize(new Customization());

	public DefaultAutoDataAttribute()
		: base(FixtureFactory)

	{
	}
}