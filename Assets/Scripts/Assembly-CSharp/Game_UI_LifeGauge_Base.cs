using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Game_UI_LifeGauge_Base : MonoBehaviour
{
	public static readonly int playerNum;

	public Color[] m_acMarkColor;

	public Vector3 m_offset3D;

	public UILabel m_textLabel_CharaName;

	public UILabel m_textLabel_Serif;

	public UILabel m_textLabel_Level;

	public UISprite m_uiSprite_TurnNum;

	public GameObject m_serifObject;

	public GameObject m_serif00Object;

	public GameObject m_serif00RootObject;

	public UISlider m_lifeGauge_Fast;

	public UISlider m_lifeGauge_Log;

	public GameObject m_lockOnMark;

	public GameObject m_abnormalStateIcon;

	public UISprite m_iconColor;

	public List<int> m_StateIconList;

	public WeakIcon m_weakIcon;

	private BattleCharaData m_targetBattleCharaData;

	private bool m_drawFlag_Log;

	private bool m_drawFlag_LockOnMark;

	private bool m_drawFlag_AbnormalStateIcon;

	private int m_life_Log;

	private float m_percent_Front;

	private float m_percent_Back;

	private float m_waitSec_Now;

	private float m_waitSec_Max;

	private float m_serifSec_Now;

	private float m_serifSec_Max;

	private float m_multiSerifSec_Max;

	private float m_serifSec00_Now;

	private GameObject m_lifeGaugeObj;

	private GameObject m_bodyObj;

	public void SetData(MultiPlay_BattleMemberData data)
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	public void SetDrawUI(bool drawFlag_Now)
	{
	}

	public void SetSerif(string text = "")
	{
	}

	public void SetSerif(List<string> textList)
	{
	}

	public void SetSerifOff()
	{
	}

	private void Serif00Off()
	{
	}

	public void SetLockOnMark(bool drawFlag)
	{
	}

	public void SetAbnormalStateIcon(bool drawFlag, int id)
	{
	}

	public void SetAbnormalStateIcon(MultiPlay_BattleMemberData member, List<AbnormalState> stateList = null)
	{
	}

	public bool IsIcon(int id)
	{
		return false;
	}

	[DebuggerHidden]
	private IEnumerator DeathMethod(float waitTime)
	{
		return null;
	}
}
