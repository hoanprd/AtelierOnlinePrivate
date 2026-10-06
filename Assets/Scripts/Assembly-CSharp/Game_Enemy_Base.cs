using System;
using CharaMotion;
using UnityEngine;

public class Game_Enemy_Base : Game_Mover_Base
{
	public enum eAssetLoadKind
	{
		None = 0,
		NeedLoad = 1,
		AlreadyLoad = 2,
		NoNeed = 3
	}

	private enum eCreateStep
	{
		Wait = 0,
		LoadAssetBundle_Init = 1,
		LoadAssetBundle_Wait = 2,
		Create = 3,
		End = 4
	}

	private eCreateStep m_createStep;

	private eAssetLoadKind m_assetLoadKind;

	private bool m_isAssetLoadOK;

	private bool m_isField;

	private string m_enemyAssetPath;

	private bool[] m_moveTime;

	private bool[] m_moveWeather;

	private Action<GameObject> m_makeObjCallback;

	protected long m_fieldEnemyNo;

	protected eEnemyKind m_myEnemyKind;

	protected int m_myEnemySubId;

	protected eFEnemyAIType m_aiType;

	protected eFakeEnemy m_fakeKind;

	protected Game_Animal_EnemyFader m_myAnimalBase;

	protected GameObject m_overHeadObj;

	private Animation m_myAnimation;

	protected string m_currentAnimeName;

	protected float m_animeSpeed;

	protected float m_defaultScale;

	protected GameObject m_enemyObj;

	protected Game_Gimmick_CheckEnemy m_fakeScr;

	protected bool m_randomEncount;

	protected MultiPlay_EnemyMemberData m_multiEnemyData;

	protected GameObject m_auraEffect;

	protected eEnemyAuraSize m_fieldAuraSize;

	protected Game_Enemy_FaceData m_face;

	public static string GetAssetPath(int enemyKind, int enemySubId)
	{
		return null;
	}

	public bool IsEnemyObjCreate()
	{
		return false;
	}

	protected override void Update()
	{
	}

	protected virtual bool Make(bool resource = false)
	{
		return false;
	}

	protected virtual void MakeAfter_F()
	{
	}

	protected virtual void MakeAfter_B()
	{
	}

	public eEnemyKind GetKind()
	{
		return eEnemyKind.None;
	}

	public virtual void SetData_F(long enemyId, int df, int moveTime, int moveWeather, eFEnemyAIType ai, eFakeEnemy fake, bool isRandom, int level, int auraSize, Action<GameObject> makeCallBack)
	{
	}

	public virtual void SetData_F(long enemyId, int df, bool[] moveTime, bool[] moveWeather, eFEnemyAIType ai, eFakeEnemy fake, bool isRandom, int level, int auraSize, Action<GameObject> makeCallBack)
	{
	}

	public virtual void SetData_B(MultiPlay_EnemyMemberData enemyData, Action<GameObject> makeCallBack)
	{
	}

	public virtual void SetData(int df, Action<GameObject> makeCallBack)
	{
	}

	public void SetAura(bool sw, int df = 0)
	{
	}

	public void SetAura(bool sw, eEnemyAuraSize size)
	{
	}

	public virtual void SetAura(bool sw, eEffectKind effect)
	{
	}

	private eEffectKind GetAura(int df)
	{
		return eEffectKind.Touch_Hit;
	}

	private eEffectKind GetAura(eEnemyAuraSize size)
	{
		return eEffectKind.Touch_Hit;
	}

	public virtual void SetFake(bool flag)
	{
	}

	public GameObject SetOverHeadIcon(bool flag, eOverHeadPos pos, eOverHeadIcon icon, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
		return null;
	}

	public GameObject SetOverHeadIcon(bool flag, eOverHeadPos pos, EEmoticon emote, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
		return null;
	}

	public void SetActive_OverHeadIcon(bool active, eOverHeadPos pos)
	{
	}

	public void SetCullingEnable(bool bEnable)
	{
	}

	public void SurpriseJump(Vector3 targetPos)
	{
	}

	public void SetAnimation(BattleCharaData.eActionKind action, bool ignoreSame = false)
	{
	}

	protected bool SetAnimation(string stateName, float speed, bool ignoreSame = false)
	{
		return false;
	}

	public void SetFace(eFaceKind kind, int frame)
	{
	}

	public void SetFace(eExpKind_Eye eye, eExpKind_Mouth mouth, int frame, bool loop = false)
	{
	}

	public void SetFace(string name, int frame)
	{
	}
}
