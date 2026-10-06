using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

internal class PhotonHandler : MonoBehaviour
{
	public static PhotonHandler SP;

	public int updateInterval;

	public int updateIntervalOnSerialize;

	private int nextSendTickCount;

	private int nextSendTickCountOnSerialize;

	private static bool sendThreadShouldRun;

	private static Stopwatch timerToStopConnectionInBackground;

	protected internal static bool AppQuits;

	protected internal static Type PingImplementation;

	private const string PlayerPrefsKey = "PUNCloudBestRegion";

	internal static CloudRegionCode BestRegionCodeInPreferences
	{
		get
		{
			return CloudRegionCode.eu;
		}
		set
		{
		}
	}

	protected void Awake()
	{
	}

	protected void Start()
	{
	}

	protected void OnApplicationQuit()
	{
	}

	protected void OnApplicationPause(bool pause)
	{
	}

	protected void OnDestroy()
	{
	}

	protected void Update()
	{
	}

	protected void OnJoinedRoom()
	{
	}

	protected void OnCreatedRoom()
	{
	}

	public static void StartFallbackSendAckThread()
	{
	}

	public static void StopFallbackSendAckThread()
	{
	}

	public static bool FallbackSendAckThread()
	{
		return false;
	}

	protected internal static void PingAvailableRegionsAndConnectToBest()
	{
	}

	[DebuggerHidden]
	internal IEnumerator PingAvailableRegionsCoroutine(bool connectToBest)
	{
		return null;
	}
}
