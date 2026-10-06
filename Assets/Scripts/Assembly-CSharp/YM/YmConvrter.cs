using System;
using System.Collections.Generic;
using UnityEngine;

namespace YM
{
	public static class YmConvrter
	{
		public static Vector2 ToVector2(object obj)
		{
			return default(Vector2);
		}

		public static Vector3 ToVector3(object obj)
		{
			return default(Vector3);
		}

		public static Quaternion ToQuaternion(object obj)
		{
			return default(Quaternion);
		}

		public static object[] ToObjectArray(this Vector2 val)
		{
			return null;
		}

		public static object[] ToObjectArray(this Vector3 val)
		{
			return null;
		}

		public static object[] ToObjectArray(this Quaternion val)
		{
			return null;
		}

		public static object[] ToObjectArray(object val)
		{
			return null;
		}

		public static Dictionary<int, string> ToDictionary(object obj)
		{
			return null;
		}

		public static Dictionary<long, string> ToDictionaryRckList(object obj)
		{
			return null;
		}

		private static List<float> _prepare(object value)
		{
			return null;
		}

		public static object ChangeType(object value, Type conversionType)
		{
			return null;
		}

		private static object _convert(object value, Type conversionType)
		{
			return null;
		}
	}
}
