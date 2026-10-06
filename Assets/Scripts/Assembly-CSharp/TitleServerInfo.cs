using System;

[Serializable]
public class TitleServerInfo
{
	[Serializable]
	public class UrlInfo
	{
		public string API;
	}

	public UrlInfo URL;

	public int SFG;
}
