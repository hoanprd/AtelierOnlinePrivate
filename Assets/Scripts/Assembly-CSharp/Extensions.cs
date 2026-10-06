using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

public static class Extensions
{
	public static Dictionary<MethodInfo, ParameterInfo[]> ParametersOfMethods;

	public static ParameterInfo[] GetCachedParemeters(this MethodInfo mo)
	{
		return null;
	}

	public static PhotonView[] GetPhotonViewsInChildren(this GameObject go)
	{
		return null;
	}

	public static PhotonView GetPhotonView(this GameObject go)
	{
		return null;
	}

	public static bool AlmostEquals(this Vector3 target, Vector3 second, float sqrMagnitudePrecision)
	{
		return false;
	}

	public static bool AlmostEquals(this Vector2 target, Vector2 second, float sqrMagnitudePrecision)
	{
		return false;
	}

	public static bool AlmostEquals(this Quaternion target, Quaternion second, float maxAngle)
	{
		return false;
	}

	public static bool AlmostEquals(this float target, float second, float floatDiff)
	{
		return false;
	}

	public static void Merge(this IDictionary target, IDictionary addHash)
	{
	}

	public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
	{
	}

	public static string ToStringFull(this IDictionary origin)
	{
		return null;
	}

	public static string ToStringFull(this object[] data)
	{
		return null;
	}

	public static ExitGames.Client.Photon.Hashtable StripToStringKeys(this IDictionary original)
	{
		return null;
	}

	public static void StripKeysWithNullValues(this IDictionary original)
	{
	}

	public static bool Contains(this int[] target, int nr)
	{
		return false;
	}
}
