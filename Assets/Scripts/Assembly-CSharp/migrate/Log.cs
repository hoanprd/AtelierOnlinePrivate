namespace migrate
{
	internal class Log
	{
		public enum LogLevelType
		{
			DEBUG = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3,
			NONE = 4
		}

		public static LogLevelType LogLevel { get; set; }

		public static string ComponentName { get; set; }

		private static string MakeLogString(string message, object classObj, string methodName)
		{
			return null;
		}

		public static void Debug(string message, object classObj = null, string methodName = null)
		{
		}

		public static void Info(string message, object classObj = null, string methodName = null)
		{
		}

		public static void Warn(string message, object classObj = null, string methodName = null)
		{
		}

		public static void Error(string message, object classObj = null, string methodName = null)
		{
		}
	}
}
