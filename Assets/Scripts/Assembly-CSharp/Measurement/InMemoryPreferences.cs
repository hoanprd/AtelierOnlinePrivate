using System.Collections.Generic;

namespace Measurement
{
	public class InMemoryPreferences : IPreferences
	{
		public const string DefaultUserId = "DUMMY_USER_ID";

		public string userId;

		public Dictionary<string, SendState> mapSendState;

		public string GetUserId()
		{
			return null;
		}

		public SendState GetSendState(string key)
		{
			return SendState.Unsent;
		}

		public void SaveSendState(string key, SendState sendState)
		{
		}

		public void Reset()
		{
		}
	}
}
