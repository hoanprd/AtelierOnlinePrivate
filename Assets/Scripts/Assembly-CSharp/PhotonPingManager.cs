using System.Collections;
using System.Diagnostics;

public class PhotonPingManager
{
	public bool UseNative;

	public static int Attempts;

	public static bool IgnoreInitialAttempt;

	public static int MaxMilliseconsPerPing;

	private const string wssProtocolString = "wss://";

	private int PingsRunning;

	public Region BestRegion
	{
		get
		{
			return null;
		}
	}

	public bool Done
	{
		get
		{
			return false;
		}
	}

	[DebuggerHidden]
	public IEnumerator PingSocket(Region region)
	{
		return null;
	}

	public static string ResolveHost(string hostName)
	{
		return null;
	}
}
