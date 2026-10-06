using System;

public class Region
{
	public CloudRegionCode Code;

	public string Cluster;

	public string HostAndPort;

	public int Ping;

	public Region(CloudRegionCode code)
	{
	}

	public Region(CloudRegionCode code, string regionCodeString, string address)
	{
	}

	public static CloudRegionCode Parse(string codeAsString)
	{
		return CloudRegionCode.eu;
	}

	internal static CloudRegionFlag ParseFlag(CloudRegionCode region)
	{
		return (CloudRegionFlag)0;
	}

	[Obsolete]
	internal static CloudRegionFlag ParseFlag(string codeAsString)
	{
		return (CloudRegionFlag)0;
	}

	public override string ToString()
	{
		return null;
	}
}
