using System;

[Serializable]
public class CreateUser
{
	[Serializable]
	public class UserInfo
	{
		public long ID;

		public string CD;

		public string GUID;
	}

	public UserInfo USER;
}
