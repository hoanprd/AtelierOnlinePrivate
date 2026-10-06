namespace Measurement
{
	public class AppsFlyerTestSpy : IAppsFlyer
	{
		private const string Tag = "[AppsFlyerTestSpy] ";

		public static AppsFlyerEvent LastEvent;

		public static string GetLastEventName()
		{
			return null;
		}

		public static string GetLastEventValue(string key)
		{
			return null;
		}

		public void TrackEvent(AppsFlyerEvent appsFlyerEvent)
		{
		}
	}
}
