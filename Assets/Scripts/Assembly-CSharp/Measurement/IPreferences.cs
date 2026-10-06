namespace Measurement
{
	public interface IPreferences
	{
		string GetUserId();

		SendState GetSendState(string key);

		void SaveSendState(string key, SendState sendState);
	}
}
