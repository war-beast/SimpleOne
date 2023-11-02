using System.ComponentModel;
using System.Reflection;

namespace SimpleAlgo.Extensions;

public static class EnumExtensions
{
	public static string GetEnumDescription<TEnum>(this TEnum value)
		where TEnum : struct
	{
		MemberInfo? enumMember = value.GetType().GetMember(value.ToString() ?? string.Empty).FirstOrDefault();
		DescriptionAttribute? descriptionAttribute =
			enumMember == null
				? default
				: enumMember.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
		return
			descriptionAttribute == null
				? value.ToString() ?? string.Empty
				: descriptionAttribute.Description;
	}
}