using UnityEngine;

public class System_GlobalValue : MonoBehaviour
{
	private static System_GlobalValue g_scrInst;

	private static DB_SystemInfo stSystemInfo;

	private static DB_NetworkInfo stNetworkInfo;

	private static DB_GameInfo stGameInfo;

	private static DB_UserInfo stUserInfo;

	static System_GlobalValue()
	{
		stSystemInfo = new DB_SystemInfo();
		stNetworkInfo = new DB_NetworkInfo();
		stGameInfo = new DB_GameInfo();
		stUserInfo = new DB_UserInfo();
		stUserInfo.Initialize();
	}

	private void Awake()
	{
		if (g_scrInst != null && g_scrInst != this)
		{
			Object.Destroy(gameObject);
			return;
		}
		g_scrInst = this;
		if (transform.parent == null)
		{
			Object.DontDestroyOnLoad(gameObject);
		}
	}

	public static System_GlobalValue GetInst()
	{
		return g_scrInst;
	}

	public static DB_SystemInfo GetSystemInfo()
	{
		if (stSystemInfo == null)
		{
			stSystemInfo = new DB_SystemInfo();
		}
		return stSystemInfo;
	}

	public static DB_NetworkInfo GetNetworkInfo()
	{
		if (stNetworkInfo == null)
		{
			stNetworkInfo = new DB_NetworkInfo();
		}
		return stNetworkInfo;
	}

	public static DB_UserInfo GetUserInfo()
	{
		if (stUserInfo == null)
		{
			stUserInfo = new DB_UserInfo();
			stUserInfo.Initialize();
		}
		else if (stUserInfo.stOptionData == null)
		{
			stUserInfo.Initialize();
		}
		return stUserInfo;
	}

	public static DB_GameInfo GetGameInfo()
	{
		if (stGameInfo == null)
		{
			stGameInfo = new DB_GameInfo();
		}
		return stGameInfo;
	}
}
