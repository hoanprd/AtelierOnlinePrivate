using System;

public class FriendInfo
{
	[Obsolete]
	public string Name
	{
		get
		{
			return null;
		}
	}

	public string UserId { get; protected internal set; }

	public bool IsOnline { get; protected internal set; }

	public string Room { get; protected internal set; }

	public bool IsInRoom
	{
		get
		{
			return false;
		}
	}

	public override string ToString()
	{
		return null;
	}
}
