using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.DesignPatterns.Shared;

public interface INameAndType<out T>
{
    string Name { get; }

    T Type { get; }
}