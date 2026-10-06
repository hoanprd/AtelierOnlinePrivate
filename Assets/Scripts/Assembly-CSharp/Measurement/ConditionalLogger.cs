using System;
using UnityEngine;

namespace Measurement
{
	public static class ConditionalLogger
	{
		private const string Condition = "APP_DEBUG";

		public static void Assert(bool condition)
		{
		}

		public static void Assert(bool condition, object message)
		{
		}

		public static void AssertNotNull(object target, string name)
		{
		}

		public static void AssertFormat(bool condition, string format, params object[] args)
		{
		}

		public static void Log(object message)
		{
		}

		public static void LogFormat(string format, params object[] args)
		{
		}

		public static void LogAssertion(object message)
		{
		}

		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		public static void LogError(object message)
		{
		}

		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		public static void LogException(Exception exception)
		{
		}

		public static void LogWarning(object message)
		{
		}

		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		public static void Log(object message, Color color)
		{
		}
	}
}
