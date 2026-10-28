public class DB_UserInfo
{
	public DB_OptionData stOptionData = new DB_OptionData();

	public DB_UserInfo()
	{
		Initialize();
	}

	public void Initialize()
	{
		if (stOptionData == null)
		{
			stOptionData = new DB_OptionData();
		}
		stOptionData.Initialize();
	}
}
