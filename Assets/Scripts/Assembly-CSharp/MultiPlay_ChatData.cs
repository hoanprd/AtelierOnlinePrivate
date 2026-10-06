public class MultiPlay_ChatData
{
	public int PlayerID;

	public long UserID;

	public int Type;

	public string Text;

	public int Situation;

	public MultiPlay_ChatData(int id, long userId, int type, string text, int situation)
	{
	}

	public bool IsIgnore()
	{
		return false;
	}
}
