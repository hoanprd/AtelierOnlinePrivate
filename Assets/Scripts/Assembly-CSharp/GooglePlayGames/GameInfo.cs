namespace GooglePlayGames
{
	public static class GameInfo
	{
		private const string UnescapedApplicationId = "APP_ID";

		private const string UnescapedWebClientId = "WEB_CLIENTID";

		private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";

		public const string ApplicationId = "937558310781";

		public const string WebClientId = "937558310781-671p1gsph4nfl2bho0cjpc7jjq46krbp.apps.googleusercontent.com";

		public const string NearbyConnectionServiceId = "__NEARBY_SERVICE_ID__";

		public static bool ApplicationIdInitialized()
		{
			return false;
		}

		public static bool WebClientIdInitialized()
		{
			return false;
		}

		public static bool NearbyConnectionsInitialized()
		{
			return false;
		}

		private static string ToEscapedToken(string token)
		{
			return null;
		}
	}
}
