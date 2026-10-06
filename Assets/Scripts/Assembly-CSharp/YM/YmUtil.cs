using System;
using System.Collections.Generic;
using System.Reflection;

namespace YM
{
	public static class YmUtil
	{
		public static TimeChecker ymChecker;

		public static Dictionary<string, MethodInfo> ScanMethods(Type type, Type scanType)
		{
			return null;
		}

		public static T[] ToArray<T>(IList<T> iList) where T : new()
		{
			return null;
		}

		public static byte[] GetMsgPack<T>(T param)
		{
			return null;
		}

		public static T Analysis<T>(byte[] msgpack)
		{
			return default(T);
		}
	}
}
