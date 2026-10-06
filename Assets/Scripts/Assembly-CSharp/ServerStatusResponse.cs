using System;

[Serializable]
public class ServerStatusResponse : ResponseDataCommon
{
	[Serializable]
	public class Status
	{
		[Serializable]
		public class UrlInfo
		{
			public string API;

			public string WEB;

			public string ASS;
		}

		public UrlInfo URL;
	}

	public Status API;
}
