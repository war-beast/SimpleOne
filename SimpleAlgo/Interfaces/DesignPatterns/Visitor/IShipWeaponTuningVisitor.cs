namespace SimpleAlgo.Interfaces.DesignPatterns.Visitor;

public interface IShipWeaponTuningVisitor
{
	string TuneLightShipWeapon(IShipWeaponContainable ship);

	string TuneMiddleShipWeapon(IShipWeaponContainable ship);

	string TuneHeavyShipWeapon(IShipWeaponContainable ship);
}