namespace UniClipboard
{
	public interface IClipboard
	{
		string GetText();

		void SetText(string text);
	}
}
