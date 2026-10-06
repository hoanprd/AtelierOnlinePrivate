using System;
using ExitGames.Client.Photon;

public class RoomOptions
{
	private bool isVisibleField;

	private bool isOpenField;

	public byte MaxPlayers;

	public int PlayerTtl;

	public int EmptyRoomTtl;

	private bool cleanupCacheOnLeaveField;

	public Hashtable CustomRoomProperties;

	public string[] CustomRoomPropertiesForLobby;

	public string[] Plugins;

	private bool suppressRoomEventsField;

	private bool publishUserIdField;

	private bool deleteNullPropertiesField;

	public bool IsVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CleanupCacheOnLeave
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SuppressRoomEvents
	{
		get
		{
			return false;
		}
	}

	public bool PublishUserId
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DeleteNullProperties
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
	public bool isVisible
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
	public bool isOpen
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
	public byte maxPlayers
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
	public bool cleanupCacheOnLeave
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
	public Hashtable customRoomProperties
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete]
	public string[] customRoomPropertiesForLobby
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete]
	public string[] plugins
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete]
	public bool suppressRoomEvents
	{
		get
		{
			return false;
		}
	}

	[Obsolete]
	public bool publishUserId
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
