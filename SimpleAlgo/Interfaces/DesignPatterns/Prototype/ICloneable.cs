namespace SimpleAlgo.Interfaces.DesignPatterns.Prototype;

/// <summary>
/// Создание клона объекта
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICloneable<out T>
{
	T Clone();
}