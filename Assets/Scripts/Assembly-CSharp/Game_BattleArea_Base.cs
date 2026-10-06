using System;
using System.Collections.Generic;
using UnityEngine;

public class Game_BattleArea_Base : System_Mover_Base
{
	public enum eTimeScaleKind
	{
		Main = 0,
		Direction = 1,
		EnumMax = 2
	}

	protected enum eMainStep
	{
		First_Init = 0,
		Battle_Init = 1,
		Battle_Sync = 2,
		Battle_Wait = 3,
		Cinema_Wait = 4,
		Result_Init = 5,
		Result_Wait = 6,
		Last_Init = 7,
		Last_Wait = 8,
		End = 9
	}

	public GameObject[] m_backgroundObj;

	public GameObject[] m_backgroundSubObj;

	public GameObject m_targetSkyObj;

	protected Transform m_objectRoot;

	protected List<GameObject> m_removeObjList_Last;

	protected GameObject m_skillObj_Break;

	protected List<BattleChestData> m_chestDataList;

	public List<GameObject> m_damageObjList;

	[NonSerialized]
	public string m_ABpath;

	[NonSerialized]
	public bool m_isRemain;

	protected string[] m_skyTexNameArray;

	protected Vector3[] m_charaPos_Player;

	protected Vector3[] m_charaPos_Player_Large;

	protected Vector3[] m_charaPos_Player_Enter;

	protected Vector3[] m_charaPos_Enemy;

	protected Vector3[] m_charaPos_Enemy_Large;

	public static readonly int m_controlPlayerCharaId;

	protected float[] m_timeScaleArray;

	protected static readonly float m_timeScale_Default;

	protected static readonly float m_timeScale_Main_Fast;

	protected static readonly float m_timeScale_Dir_Slow;

	protected bool m_timeScale_ToggleLog;

	protected MultiPlay_BattleData m_battleData;

	protected eMainStep m_mainStep;

	protected BattleCharaData m_targetData_Attack;

	protected void InitTimeScale()
	{
	}

	public void SetTimeScale(eTimeScaleKind kind, float scale)
	{
	}

	protected void UpdateTimeScale()
	{
	}

	protected override void Awake()
	{
	}

	public void SetBackgroundObj(int id)
	{
	}

	public void LoadObj()
	{
	}

	protected void SetSkyTexture()
	{
	}

	protected virtual void SetCharacterObj()
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected virtual void Battle_Initialize()
	{
	}

	protected virtual void Battle_Update()
	{
	}

	public void SetDamage(BattleCharaData damageMember, int damageValue, int elementID = 0, bool weak = false, int result = 0)
	{
	}

	public void ClearDamage()
	{
	}

	protected void SetCamera_CharaNode()
	{
	}

	public List<BattleChestData> GetChestList()
	{
		return null;
	}
}
