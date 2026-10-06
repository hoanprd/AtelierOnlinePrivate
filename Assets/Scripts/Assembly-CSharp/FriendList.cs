using System;
using System.Collections.Generic;

[Serializable]
public class FriendList
{
	[Serializable]
	public class FriendLimit
	{
		public int FRND;

		public int IGNR;

		public int RCNT;
	}

	public List<FriendData> FRND;

	public List<FriendData> APLI;

	public List<FriendData> APLD;

	public List<FriendData> IGNR;

	public List<FriendData> RCNT;

	public FriendLimit MAX;

	public List<FriendData> GetAll()
	{
		return null;
	}

	public List<long> Get(EFriendState state)
	{
		return null;
	}

	public void Init(List<FriendData> list, List<long> rcnt)
	{
	}

	public void Update(FriendDetail detail, List<long> rcnt)
	{
	}

	public void Update(FriendData data, List<long> rcnt)
	{
	}

	public string GetIGNRStringList()
	{
		return null;
	}
}
