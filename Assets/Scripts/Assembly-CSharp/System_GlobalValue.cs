using UnityEngine;

public class System_GlobalValue : MonoBehaviour
{
	private static System_GlobalValue g_scrInst;

	private static DB_SystemInfo stSystemInfo;

	private static DB_NetworkInfo stNetworkInfo;

	private static DB_GameInfo stGameInfo;

	private static DB_UserInfo stUserInfo;

	private void Awake()
	{
	}

	public static System_GlobalValue GetInst()
	{
		return null;
	}

	public static DB_SystemInfo GetSystemInfo()
	{
		return null;
	}

	public static DB_NetworkInfo GetNetworkInfo()
	{
		return null;
	}

	public static DB_UserInfo GetUserInfo()
	{
		return null;
	}

	public static DB_GameInfo GetGameInfo()
	{
		return null;
	}
}
