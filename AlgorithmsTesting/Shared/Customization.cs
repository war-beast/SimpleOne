using AutoFixture;
using SimpleAlgo.Interfaces.SortingAlgorithms;
using SimpleAlgo.Services.SortingAlgorithms;

namespace AlgorithmsTesting.Shared;

public class Customization : ICustomization
{
	private readonly SortAlgoFactory<int> _sortAlgoFactory;
	private readonly AlgorithmsService<int> _service;

	public Customization() :
		this(new SortAlgoFactory<int>(new BubbleSortingStrategy<int>(),
		new ShakerSortingStrategy<int>(),
		new CombSortStrategy<int>(),
		new InsertionSortingStrategy<int>(),
		new QuickSortingStrategy<int>(),
		new MergeSortingStrategy<int>()))
	{
	}

	public Customization(SortAlgoFactory<int> sortAlgoFactory)
	{
		_sortAlgoFactory = sortAlgoFactory;
		_service = new AlgorithmsService<int>(_sortAlgoFactory);
	}

	public void Customize(IFixture fixture)
	{
		fixture.Inject<ISortAlgoFactory<int>>(_sortAlgoFactory);
		fixture.Inject<IAlgorithmsService<int>>(_service);
	}
}