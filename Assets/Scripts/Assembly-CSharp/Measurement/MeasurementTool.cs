using System;
using System.Collections.Generic;

namespace Measurement
{
	public static class MeasurementTool
	{
		public enum eCommonEvent
		{
			eAlterLv5 = 0,
			eAlterLv10 = 1,
			eAlterLv30 = 2,
			eGoToFriend = 3
		}

		private const string Tag = "[MeasurementTool] ";

		private static readonly Dictionary<eCommonEvent, AppsFlyerEvent> CommonEvents;

		private static IAppsFlyer AppsFlyerImplementation;

		private static IPreferences PreferencesImplementation;

		public static void Init()
		{
		}

		public static void Dispose()
		{
		}

		public static void TrackEvent_Common(eCommonEvent commonEvent)
		{
		}

		public static void TrackEvent_Purchase(ProductInfo productInfo)
		{
		}

		public static void TrackEvent_ClearChapter17()
		{
		}

		private static void InternalInit(IPreferences preferences)
		{
		}

		private static void HandleError(Exception exception)
		{
		}

		private static void Warning(string message)
		{
		}

		private static void ThrowIfDebug(Exception exception)
		{
		}
	}
}
