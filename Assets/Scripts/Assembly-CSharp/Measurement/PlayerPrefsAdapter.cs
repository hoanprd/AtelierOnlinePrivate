namespace Measurement
{
	public class PlayerPrefsAdapter : IPreferences
	{
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
	}
}
