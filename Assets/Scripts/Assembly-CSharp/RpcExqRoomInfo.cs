using System;

[Serializable]
public class RpcExqRoomInfo
{
	public long userId;

	public int roomPlan;

	public int roomMemNum;

	public string roomComment;

	public long transferOwnerId;

	public bool isReady;

	public int questId;

	public long forceKickUserId;
}
