using System.Collections.Generic;
using UnityEngine;

public class MasterRoomPlan : ScriptableObject
{
	public List<RoomPlan> List;

	private RoomPlan _filterSelected;

	public RoomPlan filterSelected
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RoomPlan defaultSelected
	{
		get
		{
			return null;
		}
	}

	public RoomPlan Find(int df)
	{
		return null;
	}
}
