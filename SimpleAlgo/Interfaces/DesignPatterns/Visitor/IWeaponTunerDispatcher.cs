namespace SimpleAlgo.Interfaces.DesignPatterns.Visitor;

public interface IWeaponTunerDispatcher
{
	void Add(IShipWeaponContainable ship);
	void Remove(IShipWeaponContainable ship);
	string TuneWeapon(IShipWeaponTuningVisitor visitor);
}