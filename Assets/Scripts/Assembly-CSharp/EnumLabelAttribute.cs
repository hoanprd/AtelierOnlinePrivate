using System;
using UnityEngine;

public class EnumLabelAttribute : PropertyAttribute
{
	private static readonly string[] timeName;

	private static readonly string[] weatherName;

	public string[] Names { get; private set; }

	public EnumLabelAttribute(Type enumType)
	{
	}
}
