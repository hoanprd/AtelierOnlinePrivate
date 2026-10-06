using System.Collections.Generic;
using UnityEngine;

public class BattleTurnIcon_MultiPlay : MonoBehaviour
{
	private enum EAnimKind
	{
		eUP = 0,
		eDOWN = 1,
		eSLIDEIN = 2,
		eSLIDEOUT = 3,
		eLIGHT = 4
	}

	public GameObject m_goSkillReserve;

	public GameObject m_sCharaIcon;

	public GameObject m_sEnemyIcon;

	private UISprite m_CharaActionTurnBase;

	private GameObject m_CharaActionTurnLab;

	private UILabel m_CharaActionTurnLabLabel;

	private GameObject m_CharaColorMark;

	private UISprite m_CharaColorMarkSprite;

	private GameObject m_CharaMyMark;

	private UITweenReset m_sAnim;

	private List<UITweenReset> m_vsAnimList;

	private bool m_bInOut_InFlag;

	public Color[] enemyIconColor;

	public void InitData(GameObject rootObj)
	{
	}

	public void UpdateIcon(MultiPlay_BattleData.MultiPlay_BattleActionTurnData actionMember, int iconNum)
	{
	}

	private void StartAnim(EAnimKind kind)
	{
	}

	public void IconReset(Vector3 nowPos)
	{
	}

	public void StartAnim_In()
	{
	}

	public void StartAnim_Out()
	{
	}

	public void StartAnim_UP()
	{
	}

	public void StartAnim_Light()
	{
	}

	public void SetSkillReserve(bool enable)
	{
	}
}
