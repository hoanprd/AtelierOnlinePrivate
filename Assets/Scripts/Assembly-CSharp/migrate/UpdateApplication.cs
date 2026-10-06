namespace migrate
{
	internal class UpdateApplication
	{
		private enum ServerFlagValue
		{
			None = -1,
			Run = 0,
			Update = 1
		}

		public static bool IsNeed(ServerInfoResponse server_info_response)
		{
			return false;
		}

		public static void OpenStore()
		{
		}
	}
}
