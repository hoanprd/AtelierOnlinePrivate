public static class TurnExtensions
{
	public static readonly string TurnPropKey;

	public static readonly string TurnStartPropKey;

	public static readonly string FinishedTurnPropKey;

	public static void SetTurn(this Room room, int turn, bool setStartTime = false)
	{
	}

	public static int GetTurn(this RoomInfo room)
	{
		return 0;
	}

	public static int GetTurnStart(this RoomInfo room)
	{
		return 0;
	}

	public static int GetFinishedTurn(this PhotonPlayer player)
	{
		return 0;
	}

	public static void SetFinishedTurn(this PhotonPlayer player, int turn)
	{
	}
}
