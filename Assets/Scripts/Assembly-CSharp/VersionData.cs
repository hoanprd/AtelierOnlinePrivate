using System;

[Serializable]
public class VersionData
{
	public bool download;

	public bool raw;

	public int timing;

	public string path;

	public string hash;

	public int required;

	public int split_num;

	public long size;

	public bool update;

	public bool Compare(VersionData target)
	{
		return false;
	}
}
