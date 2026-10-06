using UnityEngine;

public class Game_MA_AreaNameColl : Game_MA_HitColl_Base
{
	public enum eDir
	{
		All = 0,
		Forward = 1,
		Back = 2,
		Right = 3,
		Left = 4,
		Inside = 5
	}

	private static int s_sAreaNameId_Log;

	public int m_areaNameId;

	public eDir[] m_enableDirection;

	public bool m_isAgainOK;

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}

	private eDir GetDirection(Vector3 playerPos)
	{
		return eDir.All;
	}
}
