using System;

[Serializable]
public class ExploreRoomInfo
{
	[Serializable]
	public class RoomInfo
	{
		public int DF;

		public int CNT;
	}

	public RoomInfo[] FD;
}
