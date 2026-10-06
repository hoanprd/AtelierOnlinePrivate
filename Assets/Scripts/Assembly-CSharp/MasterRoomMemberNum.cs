using System.Collections.Generic;
using UnityEngine;

public class MasterRoomMemberNum : ScriptableObject
{
	public List<RoomMemberNum> List;

	private RoomMemberNum _filterSelected;

	public RoomMemberNum filterSelected
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RoomMemberNum defaultSelected
	{
		get
		{
			return null;
		}
	}

	public RoomMemberNum Find(int df)
	{
		return null;
	}
}
