using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class Util
{
	private static readonly DateTime UNIX_EPOCH;

	private const string csSTRING_IV = "Tc3Pw8C7";

	private const string csSTRING_KEY = "W7nX4jeu";

	public static string GetAssetFullPath(string path)
	{
		return null;
	}

	public static string GetAssetFileName(string path, bool encrypt = true)
	{
		return null;
	}

	public static string GetObjectPath(GameObject obj)
	{
		return null;
	}

	public static Transform FindOfName(Transform parent, string prefabName)
	{
		return null;
	}

	public static T FindObjectFromName<T>(GameObject root, string name = null) where T : Component
	{
		return null;
	}

	public static List<Transform> MultiFindOfName(Transform parent, string prefabName)
	{
		return null;
	}

	public static Transform FindOfNameEx(Transform parent, string prefabName)
	{
		return null;
	}

	public static byte[] HexStringToBytes(string str)
	{
		return null;
	}

	public static byte[] HexStringToBytes2(string str)
	{
		return null;
	}

	public static string BytesToHexString(byte[] bytes)
	{
		return null;
	}

	public static int GetShiftJisByte(string str)
	{
		return 0;
	}

	public static KeyValuePair<int, int> GetStrNum_EmHalf(string str)
	{
		return default(KeyValuePair<int, int>);
	}

	public static string ToMD5HashString(string src)
	{
		return null;
	}

	public static string ToMD5HashStringFromBinary(string path)
	{
		return null;
	}

	public static string ToMD5HashStringFromBinary(byte[] data)
	{
		return null;
	}

	public static string GetFileSizeText(long totalByte)
	{
		return null;
	}

	public static string GetTimeSpanString(TimeSpan timeSpan)
	{
		return null;
	}

	[DebuggerHidden]
	public static IEnumerator UnusedAssets()
	{
		return null;
	}

	public static void SetLayerRecursively(GameObject obj, int newLayer)
	{
	}

	public static GameObject InstantiateInChildren(UnityEngine.Object obj, Transform parent, bool orgSize = false, bool orgPosition = false, bool changeLayer = false)
	{
		return null;
	}

	public static T InstantiateInChildren<T>(UnityEngine.Object obj, Transform parent, bool orgSize = false, bool orgPosition = false, bool changeLayer = false)
	{
		return default(T);
	}

	public static T ArrayRand<T>(IEnumerable<T> array)
	{
		return default(T);
	}

	public static DateTime FromUnixTime(long unixTime)
	{
		return default(DateTime);
	}

	public static long FromDateTime(DateTime dateTime)
	{
		return 0L;
	}

	public static bool IsTapScreen()
	{
		return false;
	}

	public static Dictionary<string, string> SplitMulti(string text, string outer = "&", string inner = "=")
	{
		return null;
	}

	public static bool IsUrl(string input)
	{
		return false;
	}

	public static string MakeDateSpan(string open_date, string close_date)
	{
		return null;
	}

	public static string MakeDateSpan(string close_date)
	{
		return null;
	}

	public static void AddUIDepth(GameObject root, int depth)
	{
	}

	public static T GetInstance<T>(T instance, string path, Transform root = null)
	{
		return default(T);
	}

	public static T GetInstance<T>(T instance, GameObject prefab, Transform root = null, bool orgSize = false, bool orgPosition = false, bool changeLayer = false)
	{
		return default(T);
	}

	public static T GetVerticalNextObject<T>(List<T> list, T center, bool up) where T : MonoBehaviour
	{
		return null;
	}

	public static void SetEnableButton(GameObject root, bool sw)
	{
	}

	public static T GetEnumRondom<T>() where T : struct
	{
		return default(T);
	}

	public static string MakeColorText(string original, Color32 color)
	{
		return null;
	}

	public static bool HasFlag(this Enum self, Enum flag)
	{
		return false;
	}

	public static string EncryptString(string value)
	{
		return null;
	}

	public static string DecryptString(string value)
	{
		return null;
	}

	public static string EncryptString(string value, string iv, string key)
	{
		return null;
	}

	public static string DecryptString(string value, string iv, string key)
	{
		return null;
	}

	public static float GetiOSVersion()
	{
		return 0f;
	}
}
