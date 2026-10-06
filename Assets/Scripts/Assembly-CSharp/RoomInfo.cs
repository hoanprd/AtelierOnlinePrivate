using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;

public class RoomInfo
{
	private Hashtable customPropertiesField;

	protected byte maxPlayersField;

	protected int emptyRoomTtlField;

	protected int playerTtlField;

	protected string[] expectedUsersField;

	protected bool openField;

	protected bool visibleField;

	protected bool autoCleanUpField;

	protected string nameField;

	protected internal int masterClientIdField;

	private List<long> exqReadyUserList;

	public bool removedFromList { get; internal set; }

	protected internal bool serverSideMasterClient { get; private set; }

	public Hashtable CustomProperties
	{
		get
		{
			return null;
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
	}

	public int PlayerCount { get; private set; }

	public bool IsLocalClientInside { get; set; }

	public byte MaxPlayers
	{
		get
		{
			return 0;
		}
	}

	public bool IsOpen
	{
		get
		{
			return false;
		}
	}

	public bool IsVisible
	{
		get
		{
			return false;
		}
	}

	public List<long> ExqReadyUserList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EExqReadySTT extraQuestStatus
	{
		get
		{
			return EExqReadySTT.eNONE;
		}
	}

	public string comment
	{
		get
		{
			return null;
		}
	}

	public RoomPlan roomPlan
	{
		get
		{
			return null;
		}
	}

	public RoomMemberNum roomMemberNum
	{
		get
		{
			return null;
		}
	}

	public bool isOwner
	{
		get
		{
			return false;
		}
	}

	public bool isFriendOnlyRoom
	{
		get
		{
			return false;
		}
	}

	public long ownerUserId
	{
		get
		{
			return 0L;
		}
	}

	public string ownerUserName
	{
		get
		{
			return null;
		}
	}

	public string ownerUserLCharaLv
	{
		get
		{
			return null;
		}
	}

	[Obsolete]
	public Hashtable customProperties
	{
		get
		{
			return null;
		}
	}

	[Obsolete]
	public string name
	{
		get
		{
			return null;
		}
	}

	[Obsolete]
	public int playerCount
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
	public bool isLocalClientInside
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
	}

	[Obsolete]
	public bool open
	{
		get
		{
			return false;
		}
	}

	[Obsolete]
	public bool visible
	{
		get
		{
			return false;
		}
	}

	public int questId
	{
		get
		{
			return 0;
		}
	}

	protected internal RoomInfo(string roomName, Hashtable properties)
	{
	}

	public List<string> GetCustomPropertiesIdList(EPhotonHashKey hashKey)
	{
		return null;
	}

	public void SetCustomProperties(EPhotonHashKey key, string setData)
	{
	}

	public void SetCustomProperties(EPhotonHashKey key, int setData)
	{
	}

	public void AddListCustomProperties(EPhotonHashKey key, string setData, bool isDeduplication = true)
	{
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToStringFull()
	{
		return null;
	}

	protected internal void InternalCacheProperties(Hashtable propertiesToCache)
	{
	}
}
