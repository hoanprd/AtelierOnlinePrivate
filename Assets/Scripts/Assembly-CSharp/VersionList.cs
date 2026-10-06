using System;
using System.Collections.Generic;

[Serializable]
public class VersionList
{
	public bool update;

	public string lastupdate;

	public int count;

	public List<VersionData> list;

	public VersionData Find(string path)
	{
		return null;
	}

	public VersionData[] GetTimingList(int timing)
	{
		return null;
	}

	public bool Compare(VersionList target)
	{
		return false;
	}
}
