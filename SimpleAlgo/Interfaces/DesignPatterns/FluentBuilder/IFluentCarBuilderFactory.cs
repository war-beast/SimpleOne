using SimpleAlgo.Enums;

namespace SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

public interface IFluentCarBuilderFactory
{
    IFluentCarBuilder Create(BuilderTypes type);
}