using SimpleAlgo.Interfaces;

namespace SimpleAlgo.Services;

public class CombSortStrategy<T> : SortingStrategyBase<T>, ICombSortStrategy<T> where T : IComparable<T>
{
	//Делитель, по которому определяется расстояние между сравниваемыми элементами массива
	//Вычислено эмпирически какими-то умными программистами
	private const double K = 1.247;

	public override T[] Sort(T[] array)
	{
		var step = (int)Math.Floor(array.Length / K);

		while (step >= 1)
		{
			for (var i = 0; i < array.Length - step; i++)
			{
				if (array[i].CompareTo(array[i + step]) > 0)
				{
					(array[i], array[i + step]) = (array[i + step], array[i]);
				}
			}

			step = (int)Math.Floor(step / K);
		}

		return array;
	}
}