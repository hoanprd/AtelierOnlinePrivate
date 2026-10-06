using System;
using ExitGames.Client.Photon;

public class Room : RoomInfo
{
	public new string Name
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public new bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public new bool IsVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string[] PropertiesListedInLobby { get; private set; }

	public bool AutoCleanUp
	{
		get
		{
			return false;
		}
	}

	public new int MaxPlayers
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public new int PlayerCount
	{
		get
		{
			return 0;
		}
	}

	public string[] ExpectedUsers
	{
		get
		{
			return null;
		}
	}

	public int PlayerTtl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EmptyRoomTtl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected internal int MasterClientId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete]
	public new string name
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	[Obsolete]
	public new bool open
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete]
	public new bool visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete]
	public string[] propertiesListedInLobby
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	[Obsolete]
	public bool autoCleanUp
	{
		get
		{
			return false;
		}
	}

	[Obsolete]
	public new int maxPlayers
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete]
	public new int playerCount
	{
		get
		{
			return 0;
		}
	}

	[Obsolete]
	public string[] expectedUsers
	{
		get
		{
			return null;
		}
	}

	[Obsolete]
	protected internal int masterClientId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal Room(string roomName, RoomOptions options)
		: base(null, null)
	{
	}

	public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues = null, bool webForward = false)
	{
	}

	public void SetPropertiesListedInLobby(string[] propsListedInLobby)
	{
	}

	public void ClearExpectedUsers()
	{
	}

	public void SetExpectedUsers(string[] expectedUsers)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public new string ToStringFull()
	{
		return null;
	}
}
