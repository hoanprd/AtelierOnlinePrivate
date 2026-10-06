using System.Collections.Generic;
using UnityEngine;

public class BattleCharaData
{
	public enum eActionKind
	{
		Idle = 0,
		Appear = 1,
		Run_Front = 2,
		Run_Back = 3,
		Hover = 4,
		Attack_01 = 5,
		Attack_02 = 6,
		Skill_Attack = 7,
		Skill_Finish_01 = 8,
		Skill_Finish_02 = 9,
		Sink = 10,
		Victory = 11,
		Damage_Dead = 12,
		Damage_Normal = 13,
		ItemUse_01 = 14,
		Dying = 15,
		Damage_Blow_A = 1000,
		Damage_Blow_B = 1001,
		Damage_Skill_A = 1002,
		Damage_Skill_B = 1003,
		Walk = 2000,
		Run = 2001,
		StayField = 2002,
		EnumMax = 2003
	}

	private static readonly Dictionary<eActionKind, string> motionNameDic;

	public GameObject targetObj;

	public Animation targetAnim;

	private Transform cameraNode;

	public bool isPlayerSide;

	public string charaName;

	public int posId;

	public int level;

	public int life_Now;

	public int life_Max;

	public float skill0_Now;

	public float skill0_Max;

	public float skill1_Now;

	public float skill1_Max;

	public string piyori_Node;

	public bool drawFlag;

	private eActionKind currentAction;

	public Game_UI_LifeGauge_Base lifeGaugeBase;

	public BattleCharaData()
	{
	}

	public BattleCharaData(string _charaName, bool _isPlayerSide)
	{
	}

	public static string GetMotionName(eActionKind eAction)
	{
		return null;
	}

	public BattleCharaData Clone()
	{
		return null;
	}

	public bool IsDown()
	{
		return false;
	}

	public bool IsPlayerSide()
	{
		return false;
	}

	public Game_Chara_BA_Base GetCharaBase()
	{
		return null;
	}

	public void SetDrawFlag(bool enableFlag)
	{
	}

	public MakeCharaData GetMakeCharaData()
	{
		return null;
	}

	public void SetData(GameObject tempObj, string name)
	{
	}

	private Animation GetAnimation(GameObject tempObj)
	{
		return null;
	}

	public GameObject GetNode_Name(Transform parentNode, string nodeName)
	{
		return null;
	}

	public GameObject GetNode_Camera()
	{
		return null;
	}

	public GameObject GetNode_Target()
	{
		return null;
	}

	public GameObject GetNode_LifeGauge()
	{
		return null;
	}

	public GameObject GetNode_Body()
	{
		return null;
	}

	public GameObject GetNode_Body2()
	{
		return null;
	}

	public GameObject GetNode_Weapon()
	{
		return null;
	}

	public void SetAction(eActionKind kind, bool ignoreSame = false, bool bQueued = false)
	{
	}

	public void SetStop()
	{
	}

	public void SetDead(eActionKind kind)
	{
	}

	public void SetAction_Damage(bool specialFlag, int damage)
	{
	}

	public void SetRecov(int recov)
	{
	}

	public void SetSPRecov(int recov)
	{
	}

	public bool IsFinishedMotion()
	{
		return false;
	}
}
