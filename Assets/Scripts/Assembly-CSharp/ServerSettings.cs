using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;

[Serializable]
public class ServerSettings : ScriptableObject
{
	public enum HostingOption
	{
		NotSet = 0,
		PhotonCloud = 1,
		SelfHosted = 2,
		OfflineMode = 3,
		BestRegion = 4
	}

	public string AppID;

	public string VoiceAppID;

	public string ChatAppID;

	public HostingOption HostType;

	public CloudRegionCode PreferredRegion;

	public CloudRegionFlag EnabledRegions;

	public ConnectionProtocol Protocol;

	public string ServerAddress;

	public int ServerPort;

	public int VoiceServerPort;

	public bool JoinLobby;

	public bool EnableLobbyStatistics;

	public PhotonLogLevel PunLogging;

	public DebugLevel NetworkLogging;

	public bool RunInBackground;

	public List<string> RpcList;

	[HideInInspector]
	public bool DisableAutoOpenWizard;

	public static CloudRegionCode BestRegionCodeInPreferences
	{
		get
		{
			return CloudRegionCode.eu;
		}
	}

	public void UseCloudBestRegion(string cloudAppid)
	{
	}

	public void UseCloud(string cloudAppid)
	{
	}

	public void UseCloud(string cloudAppid, CloudRegionCode code)
	{
	}

	public void UseMyServer(string serverAddress, int serverPort, string application)
	{
	}

	public static bool IsAppId(string val)
	{
		return false;
	}

	public static void ResetBestRegionCodeInPreferences()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
