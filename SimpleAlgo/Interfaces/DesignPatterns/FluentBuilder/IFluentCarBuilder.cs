using SimpleAlgo.Enums;
using SimpleAlgo.Models.DesignPatterns.Builder;

namespace SimpleAlgo.Interfaces.DesignPatterns.FluentBuilder;

public interface IFluentCarBuilder
{
    BuilderTypes BuilderType { get; }

    IFluentCarBuilder BuildBody();
    IFluentCarBuilder BuildTransmission();
    IFluentCarBuilder BuildEngine();
    Car Build();
}