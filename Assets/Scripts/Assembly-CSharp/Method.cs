using System;
using System.Collections.Generic;

[Serializable]
public class Method
{
	public eMethodType type;

	public string name;

	public List<ValueList> commandList;

	public Method(eMethodType _type, string _name = "")
	{
	}
}
