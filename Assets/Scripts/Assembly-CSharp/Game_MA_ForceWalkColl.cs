using System.Collections.Generic;
using UnityEngine;

public class Game_MA_ForceWalkColl : Game_MA_HitColl_Base
{
	public enum eSituation
	{
		ToChangeMap = 0,
		FromChangeMap = 1,
		Always = 2
	}

	public static bool s_bMapChangeNow;

	public eSituation m_eSituation;

	public GameObject m_goWalkToPos;

	public List<string> m_strTalkFileList;

	protected override void HitPlayer(Game_Chara_MA_Player player)
	{
	}
}
