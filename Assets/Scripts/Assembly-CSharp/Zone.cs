using System;
using System.Collections.Generic;

[Serializable]
public class Zone
{
	public int id;

	public string name;

	public List<int> effectlist;

	public string effect;

	public List<int> strongZonelist;

	public List<int> weakZonelist;
}
