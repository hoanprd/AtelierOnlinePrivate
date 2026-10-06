using System.Collections.Generic;
using UnityEngine;

public class ExqClearTarget_MP_CharaData
{
	public int ID;

	public Vector3 Position;

	public float RotationY;

	public float AnimeSpeed;

	public long UserID;

	public int LeaderDF;

	public int AreaKind;

	public bool IsOnBoat;

	public string Name;

	public int AreaID;

	public int DungeonID;

	public int FloorID;

	public int Date;

	public int DungeonDifficulty;

	public int MotionID;

	public bool IsLeaving;

	public bool IsFloorRemoving;

	public string IgnrIDs;

	public Dictionary<int, ExqClearTarget_MP_CharaMemberData> MemberList;

	public EquipData equ;

	public EquipData cd_equ;

	public int[] cd_v;

	public InventoryInfo[] equInvList;

	public InventoryInfo[] cd_equInvList;

	private PlayerDetailManager.OthersProfile_Photon othersProf;

	public ExqClearTarget_MP_CharaData(MultiPlay_CharaData charaData)
	{
	}
}
