using System.Text;

namespace SimpleAlgo.Models.DesignPatterns.Builder;

public class Car
{
	private List<string> _parts = new ();

	private string _name;

	public Car(string name)
	{
		_name = name;
	}

	public void AddPart(string part)
	{
		_parts.Add(part);
	}

	public string ShowMe()
	{

		StringBuilder sb = new();
		sb.AppendLine(string.Empty);
		sb.AppendLine($">---------------Описание автомобиля ({_name})--------------<");

		foreach (var part in _parts)
		{
			sb.AppendLine(part);
		}

		sb.AppendLine(">---------------Конец описания--------------<");

		return sb.ToString();
	}
}